using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace Anachrophobe
{
    // This is serializable for two reasons
    // In the future I want two features, networking, and storage of timers.
    [Serializable]
    public class ActionObject : ISerializable, IDeserializationCallback
    {
        // Initialize all of our local variables.
        
        // Keep these private to prevent other parts of the program from breaking them, note, we accept strings, but never store them.
        // If there is any data in a timer we want to store, it MUST be in this class.
        private string m_Name;
        private DateTime m_StartTime;
        private TimeSpan m_Length;
        private Parsetime ParseTime = new Parsetime();
        private Color m_StartBack = Color.Black;
        private Color m_EndBack = Color.Black;

        // This is used for Serialization
        public ActionObject(SerializationInfo info, StreamingContext ctxt)
        {
            m_Name = info.GetString("m_Name");
            m_StartTime = info.GetDateTime("m_StartTime");
            m_Length = (TimeSpan)info.GetValue("m_Length", typeof(TimeSpan));
        }

        #region ISerializable Members

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("m_Name", m_Name);
            info.AddValue("m_StartTime", m_StartTime);
            info.AddValue("m_Length", m_Length);
            //info.AddValue("authserver", authserver);
        }

        #endregion

        void IDeserializationCallback.OnDeserialization(object sender)
        {
            ParseTime = new Parsetime();
            m_StartBack = Color.Black;
            m_EndBack = Color.Black;
        }

        public ActionObject()
        {

        }

        // Initialize with a start time, length (the variable is incorrectly named), and a human-friendly name
        public ActionObject(string initStartTime, string initEndTime, string initName)
        {
            // Parse our strings
            Start = ParseTime.ParseDT(initStartTime);
            Length = ParseTime.ParseTS(initEndTime);

            m_Name = initName;
        }

        // Allow public get and set of Background_Start
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

        // Allow public get and set of Background_End
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

        // Easy update method for actionClockControl use
        public bool Update(string startTime, string endTime)
        {
            try
            {
                // Parse start and length
                Start = ParseTime.ParseDT(startTime);
                Length = ParseTime.ParseTS(endTime);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Start is public get, private set. Don't ever let other classes directly mess with DateTimes
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

        // StartString is used to grab the ammount of TIME LEFT to the BEGINNING of a timer
        public String StartString
        {
            get
            {
                return convertTime(StartTime);
            }
        }

        // EndString is used to grab the ammount of TIME LEFT to the END of a tiemr
        public String EndString
        {
            get
            {
                return convertTime(EndTime);
            }
        }

        // Allow other classes read-only access to when the end of the timer is in TimeSpan format
        public TimeSpan EndTime
        {
            get
            {
                return DateTime.Now - End;
            }
        }

        // Allow other classes read-only acccess to when the start of the timer is in TimeSpan format
        public TimeSpan StartTime
        {
            get
            {
                return DateTime.Now - Start;
            }
        }

        // Allow public read-only access to the Date and Time of the end of the timer. This is only calculated here
        public DateTime End
        {
            get
            {
                return Start + Length;
            }
        }

        // Allow public read-only access, and private write access to the Length of a timer.
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

        // Once the name has been set, it can't be changed. Allow read-only access to the name.
        public String Name
        {
            get
            {
                return m_Name;
            }
        }

        // Here is where we convert from a TimeSpan to something more easially readable in string format.
        private string convertTime(TimeSpan toConvert)
        {
            try
            {
                // This is kind of special-sauce, I don't remember how I made it work.
                // Days(1 or more digits).Hours(2 digits):Minutes(2 digits):Seconds(2 digits)
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
