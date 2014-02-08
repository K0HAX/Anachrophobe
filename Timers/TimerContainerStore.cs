using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Timers
{
    [Serializable]
    public class TimerContainerStore : ISerializable
    {
        private List<TimerDatastore> m_timerList = new List<TimerDatastore>();

        public TimerContainerStore(SerializationInfo info, StreamingContext ctxt)
        {
            m_timerList = (List<TimerDatastore>)info.GetValue("m_objectsList", typeof(List<TimerDatastore>));
        }

        #region ISerializable Members

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("m_objectsList", m_timerList);
        }

        #endregion

        public IEnumerable<TimerDatastore> Timers
        {
            get { return m_timerList; }
        }

        public TimerContainerStore() { }

        //TODO: Do This
        public void Serialize(string filename)
        {
            throw new NotImplementedException();
        }

        //TODO: Do this
        public static TimerContainerStore Deserialize(string filename)
        {
            throw new NotImplementedException();
        }

        public TimerDatastore getTimer(int i)
        {
            try
            {
                return m_timerList.ElementAt(i);
            }
            catch
            {
                throw new NotSupportedException();
            }
        }

        public void addTimer(TimerDatastore timer)
        {
            try
            {
                m_timerList.Add(timer);
            }
            catch
            {
                MessageBox.Show("Error adding control");
            }
        }

        public void delTimer(TimerDatastore timer)
        {
            try
            {
                m_timerList.Remove(timer);
            }
            catch
            {
                MessageBox.Show("error removing control");
            }
        }
    }
}
