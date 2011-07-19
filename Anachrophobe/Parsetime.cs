using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anachrophobe
{
    class Parsetime
    {
        public DateTime ParseDT(string DateTimeIn)
        {
            bool m_DidItWork = false;
            DateTime m_WorkingDatetime;
            m_DidItWork = DateTime.TryParse(DateTimeIn, out m_WorkingDatetime);
            if (m_DidItWork == true)
            {
                return m_WorkingDatetime;
            }
            else
            {
                MessageBox.Show("Date/Time not formatted correctly (MM/dD/YYYY HH:MM:SSam/pm)");
                return DateTime.Now;
            }
        }

        public TimeSpan ParseTS(string TimeSpanIn)
        {
            bool m_DidItWork = false;
            TimeSpan m_WorkingTimespan;
            m_DidItWork = TimeSpan.TryParse(TimeSpanIn, out m_WorkingTimespan);
            if (m_DidItWork == true)
            {
                return m_WorkingTimespan;
            }
            else
            {
                MessageBox.Show("Timespan (length of timer) not formatted correctly (HH:MM:SS)");
                TimeSpan.TryParse("00:00:00", out m_WorkingTimespan);
                return m_WorkingTimespan;
            }
        }
    }
}
