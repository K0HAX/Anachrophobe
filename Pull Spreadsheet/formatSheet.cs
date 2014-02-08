using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Google.GData.Spreadsheets;
using Google.GData.Client;

namespace Pull_Spreadsheet
{
    class formatSheet
    {
        public DataTable dt;

        public formatSheet(string Username, string Password, string Sheet, string Worksheet)
        {
            dt = new DataTable();
            try
            {
                SpreadsheetsService service = new
                SpreadsheetsService("Anachrophobe");
                service.setUserCredentials(Username, Password);
                SpreadsheetQuery query = new SpreadsheetQuery();
                query.Title = Sheet;
                SpreadsheetFeed feed = service.Query(query);
                if (feed.Entries.Count != 1) return;

                AtomLink link =
                    feed.Entries[0].Links.FindService(GDataSpreadsheetsNameTable.WorksheetRel,
                    null);
                WorksheetQuery worksheetQuery = new
                WorksheetQuery(link.HRef.ToString());
                worksheetQuery.Title = Worksheet;
                WorksheetFeed worksheetFeed =
                    service.Query(worksheetQuery);
                if (worksheetFeed.Entries.Count != 1) return;

                WorksheetEntry worksheet =
                    (WorksheetEntry)worksheetFeed.Entries[0];

                AtomLink listFeedLink =
                    worksheet.Links.FindService(GDataSpreadsheetsNameTable.ListRel, null);

                ListQuery listQuery = new
                    ListQuery(listFeedLink.HRef.ToString());
                ListFeed listFeed = service.Query(listQuery);
                // define the table's schema
                dt.Columns.Add(new DataColumn("A", typeof(string)));
                dt.Columns.Add(new DataColumn("B", typeof(string)));
                dt.Columns.Add(new DataColumn("C", typeof(string)));
                dt.Columns.Add(new DataColumn("D", typeof(string)));
                foreach (ListEntry worksheetRow in listFeed.Entries)
                {
                    string station = string.Empty;
                    string scanData =
                        worksheetRow.Elements[0].Value.ToString();
                    string scanData1 =
                        worksheetRow.Elements[1].Value.ToString();
                    string scanData2 =
                        worksheetRow.Elements[2].Value.ToString();
                    string scanData3 =
                        worksheetRow.Elements[2].Value.ToString();
                    string[] arSD = new string[100];

                    DataRow dr = dt.NewRow();
                    dr["A"] = scanData;
                    dr["B"] = scanData1;
                    dr["C"] = scanData2;
                    dr["D"] = scanData3;
                    dt.Rows.Add(dr);

                }

                //dgwTabla.DataSource = dt;
                

            }

            catch (Exception ex)
            {
            }
        }
    }
}
