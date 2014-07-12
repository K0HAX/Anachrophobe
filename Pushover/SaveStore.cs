using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Pushover
{
    public class SaveStore
    {
        public static void SaveControls(Users Container)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileInfo fi = new FileInfo("Users.dat");
            if (fi.Exists == true)
            {
                fi.Delete();
            }
            FileStream fs = new FileStream("Users.dat", FileMode.OpenOrCreate);
            bf.Serialize(fs, Container);
            fs.Close();
        }

        public static Users LoadControls()
        {
            FileStream fs = null;
            FileInfo fi = new FileInfo("Users.dat");
            Users Container;

            if (fi.Exists == true)
            {
                try
                {
                    fs = new FileStream("Users.dat", FileMode.Open);

                    BinaryFormatter bf = new BinaryFormatter();

                    Container = (Users)bf.Deserialize(fs);

                    /*
                    for (int i = 0; i < Container.Timers.Count(); i++)
                    {
                        actionClockControl acc = new actionClockControl(Container.getTimer(i));
                        uxFlowPanel.Controls.Add(acc);
                    }
                    */
                }
                catch (FileNotFoundException)
                {
                    //MessageBox.Show("Couldn't find datastore, creating it now.");
                    Container = new Users();
                    return Container;
                }
                catch
                {
                    //MessageBox.Show("Couldn't parse file");
                    Container = new Users();
                    return Container;
                }
                finally
                {
                    if (fs != null)
                        fs.Close();
                }
            }
            else
            {
                Container = new Users();
            }
            return Container;
        }
    }
}
