using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;

namespace Pushover
{
    public class Pushover
    {
        private string m_AppToken;
        //private string m_UserKey;
        private List<string> UserKeys;
        private Users users = SaveStore.LoadControls();

        public Pushover(string AppToken)
        {
            m_AppToken = AppToken;
            //m_UserKey = UserKey;
            //UserKeys = new List<string>() { "u9b6cLVBDTrfkz4EjknDdGumPpRrc1" };
            UserKeys = users.GetUsers();
        }

        public bool SendMessage(string Message)
        {
            try
            {
                foreach (string Key in UserKeys)
                {
                    var parameters = new NameValueCollection {
                        { "token", m_AppToken },
                        { "user", Key },
                        { "message", Message }
                    };


                    using (var client = new WebClient())
                    {
                        client.UploadValues("https://api.pushover.net/1/messages.json", parameters);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
