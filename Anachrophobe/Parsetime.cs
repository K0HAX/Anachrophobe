using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anachrophobe
{
    class Parsetime
    {

        // As a preamble, I think it's pretty stupid that I had to write these functions
        // Anyway, here they are, it just makes life easier later on

        // This function takes a string that (should) be formatted as a DateTime, and makes it a DateTime
        public DateTime ParseDT(string DateTimeIn)
        {
            // We want to know later if it worked, assume it didn't for now.
            bool m_DidItWork = false;
            
            // Initialize a variable
            DateTime m_WorkingDatetime;

            // Let's do a TryParse and see if we can get something useful out of it
            // If it works, it will return true and set m_DidItWork to true.
            m_DidItWork = DateTime.TryParse(DateTimeIn, out m_WorkingDatetime);
            if (m_DidItWork == true)
            {
                // It worked! Return the result.
                return m_WorkingDatetime;
            }
            else
            {
                // It didn't work, throw a messagebox to the user.
                // And to prevent other parts of the program from crashing, return SOMETHING. I like DateTime.Now because it's obvious.
                MessageBox.Show("Date/Time not formatted correctly (MM/dD/YYYY HH:MM:SSam/pm)");
                return DateTime.Now;
            }
        }

        // This function takes a string and returns a timespan.
        public TimeSpan ParseTS(string TimeSpanIn)
        {
            // We need to know if it worked, assume it didn't.
            bool m_DidItWork = false;
            // Initialize a variable
            TimeSpan m_WorkingTimespan;
            // Try parsing the string, if it works this will return true and store the data in m_WorkingTimespan
            m_DidItWork = TimeSpan.TryParse(TimeSpanIn, out m_WorkingTimespan);
            if (m_DidItWork == true)
            {
                // It worked! Return the result
                return m_WorkingTimespan;
            }
            else
            {
                // Something went wrong, send a messagebox to the user
                // To prevent other parts of the program from breaking, return a timespan of zero.
                MessageBox.Show("Timespan (length of timer) not formatted correctly (HH:MM:SS)");
                TimeSpan.TryParse("00:00:00", out m_WorkingTimespan);
                return m_WorkingTimespan;
            }
        }
    }
}
