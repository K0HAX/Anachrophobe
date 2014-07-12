using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Pushover
{
    [Serializable]
    public class Users : ISerializable
    {
        private List<string> m_Users;

        public Users(SerializationInfo info, StreamingContext ctxt)
        {
            m_Users = (List<string>)info.GetValue("m_Users", typeof(List<string>));
        }

        #region ISerializable Members

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("m_Users", m_Users);
        }

        #endregion

        public List<string> GetUsers()
        {
            return m_Users;
        }

        public Users() {
            m_Users = new List<string>();
        }

        public bool AddUser(string UserKey)
        {
            try
            {
                string key = UserKey;
                m_Users.Add(key);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DelUser(string UserKey)
        {
            try
            {
                m_Users.Remove(UserKey);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
