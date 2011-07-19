using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace Anachrophobe
{
    [Serializable]
    public class ActionObject : ISerializable
    {
        string m_Name;

        private DateTime m_StartTime;
        private TimeSpan m_Length;
        private Parsetime ParseTime = new Parsetime();
        private Color m_StartBack = Color.Black;
        private Color m_EndBack = Color.Black;

        public ActionObject(SerializationInfo info, StreamingContext ctxt)
        {
            m_Name = (string)info.GetValue("m_Name", typeof(String));
            m_StartTime = (DateTime)info.GetValue("m_StartTime", typeof(DateTime));
            m_Length = (TimeSpan)info.GetValue("m_Length", typeof(TimeSpan));
        }

        #region ISerializable Members

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("m_Name", m_Name);
            info.AddValue("m_StartTime", m_StartTime);
            info.AddValue("m_Length", m_Length);
            //info.AddValue("authserver", authserver);
        }

        #endregion

        public ActionObject()
        {

        }

        public ActionObject(string initStartTime, string initEndTime, string initName)
        {
            Start = ParseTime.ParseDT(initStartTime);
            Length = ParseTime.ParseTS(initEndTime);

            m_Name = initName;
        }

        public Color Background_Start
        {
            get
            {
                return m_StartBack;
            }
            set
            {
                m_StartBack = value;
            }
        }

        public Color Background_End
        {
            get
            {
                return m_EndBack;
            }
            set
            {
                m_EndBack = value;
            }
        }

        public bool Update(string startTime, string endTime)
        {
            try
            {
                Start = ParseTime.ParseDT(startTime);
                Length = ParseTime.ParseTS(endTime);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DateTime Start
        {
            get
            {
                return m_StartTime;
            }
            private set
            {
                m_StartTime = value;
            }
        }

        public String StartString
        {
            get
            {
                return convertTime(StartTime);
            }
        }

        public String EndString
        {
            get
            {
                return convertTime(EndTime);
            }
        }

        public TimeSpan EndTime
        {
            get
            {
                return DateTime.Now - End;
            }
        }

        public TimeSpan StartTime
        {
            get
            {
                return DateTime.Now - Start;
            }
        }

        public DateTime End
        {
            get
            {
                return Start + Length;
            }
        }

        public TimeSpan Length
        {
            get
            {
                return m_Length;
            }

            private set
            {
                m_Length = value;
            }
        }

        public String Name
        {
            get
            {
                return m_Name;
            }
        }

        private string convertTime(TimeSpan toConvert)
        {
            try
            {
                string converttedTime = string.Format(
                    "{0}{1}{2:D2}:{3:D2}:{4:D2}",
                    toConvert.Ticks < 0 ? "-" : string.Empty,
                    Math.Abs(toConvert.Days) > 0 ? Math.Abs(toConvert.Days).ToString() + "." : string.Empty,
                    Math.Abs(toConvert.Hours),
                    Math.Abs(toConvert.Minutes),
                    Math.Abs(toConvert.Seconds));

                return converttedTime;
            }
            catch
            {
                MessageBox.Show("Error in ActionObject, convertTime");
                return "";
            }
        }
    }
}
