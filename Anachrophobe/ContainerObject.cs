using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Anachrophobe
{
    [Serializable]
    public class ContainerObject : ISerializable
    {
        private List<ActionObject> m_objectsList = new List<ActionObject>();

        public ContainerObject(SerializationInfo info, StreamingContext ctxt)
        {
            m_objectsList = (List<ActionObject>)info.GetValue("m_objectsList", typeof(List<ActionObject>));
        }

        #region ISerializable Members

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("m_objectsList", m_objectsList);
        }

        #endregion

        public IEnumerable<ActionObject> Objects
        {
            get { return m_objectsList; }
        }

        public ContainerObject() { }

        //TODO: Do This
        public void Serialize()
        {
            throw new NotImplementedException();
        }

        //TODO: Do this
        public static ContainerObject Deserialize()
        {
            throw new NotImplementedException();
        }

        public ActionObject getObject(int i)
        {
            try
            {
                return m_objectsList.ElementAt(i);
            }
            catch
            {
                throw new NotSupportedException();
            }
        }

        public void addObject(ActionObject control)
        {
            try
            {
                m_objectsList.Add(control);
            }
            catch
            {
                MessageBox.Show("Error adding control");
            }
        }

        internal void delObject(ActionObject control)
        {
            //throw new NotImplementedException();
            try
            {
                m_objectsList.Remove(control);
            }
            catch
            {
                MessageBox.Show("error removing control");
            }
        }
    }
}
