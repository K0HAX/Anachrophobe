using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Timers;

namespace Anachrophobe
{
    public delegate void ControlDyingHandler(object sender, TimerDatastore e);
    

    public partial class actionClockControl : UserControl
    {
        // Initialize some variables

        // m_BlinkTrack is used to store how many seconds this control can blink for, and the mod 2 of it is used for blinking between black and red.
        private int m_BlinkTrack;
        // m_BlinkRunning is used to store and determine if the control is blinking right now
        private bool m_BlinkRunning = false;
        // m_isFirst is only used in the YRU-Up branch, it tells the control to regenerate itself instead of self-destructing
        private bool m_isFirst = false;
        // m_Action is the ActionObject tied to this timer, it stores all the information required to regenerate this timer.
        TimerDatastore m_Action;
        // m_ErrorCount is stupid, but it is used to self-destruct the timer if it for some reason throws a fit of errors
        private int m_ErrorCount;
        // m_MaxError determines how many errors m_ErrorCount can hit before the control self-destructs
        private static int m_MaxError = 3;

        public actionClockControl()
        {
            InitializeComponent();
        }

        public actionClockControl(TimerDatastore actionObject) : this()
        {
            m_Action = actionObject;
            uxNameLabel.Text = m_Action.Name;
            uxTimeOfAction.Text = Convert.ToDateTime(m_Action.Start).ToString("MM/dd/yyyy hh:mm:ss tt");
            uxEndOfAction.Text = m_Action.Length.ToString();
        }

        // This initialization method tells the control if it is the first one in the container form
        public actionClockControl(string initStartTime, string initEndTime, string initName, bool isFirst = false) : this()
        {
            m_ErrorCount = 0;
            Match matchStart = Regex.Match(initStartTime, @"[0-9][0-9]/[0-9][0-9]/[0-9][0-9][0-9][0-9] [0-9][0-9]:[0-9][0-9]:[0-9][0-9] s?([ap]m)?$", RegexOptions.IgnoreCase);
            Match matchLength = Regex.Match(initEndTime, @"[0-9][0-9]:[0-9][0-9]:[0-9][0-9]$", RegexOptions.IgnoreCase);

            if ((matchStart.Success == false) || (matchLength.Success == false) || (initName == ""))
            {
                m_Action = new TimerDatastore(System.DateTime.Now.ToString(), "00:00:01", "ERROR");
            }
            else
            {
                m_Action = new TimerDatastore(initStartTime, initEndTime, initName);
            }
            // Parse all the stuff used to initialize the timer.
            

            uxTimeOfAction.Text = m_Action.Start.ToString();
            uxEndOfAction.Text = m_Action.Length.ToString();
            uxNameLabel.Text = m_Action.Name;
            if (isFirst == true)
                m_isFirst = true;
            EventMessenger.SendMessage(this, m_Action, true, false);
        }

        private void actionClockControl_Load(object sender, EventArgs e)
        {

        }

        public TimerDatastore giveMeObject()
        {
            return m_Action;
        }

        private void uxUpdateBtn_Click(object sender, EventArgs e)
        {
            // This sometimes breaks
            try
            {
                // Disable the updateTimer or it may break the m_Action.Update
                updateTimer.Enabled = false;
                // update the parameters of the ActionObject
                m_Action.Update(uxTimeOfAction.Text, uxEndOfAction.Text);
                // We MUST disable the blinktimer, to ensure it is not blinking right now
                blinkTimer.Enabled = false;
                m_BlinkTrack = 0;
                m_BlinkRunning = false;
                // Update the screen with current values
                uxTimeOfAction.Text = m_Action.Start.ToString();
                uxEndOfAction.Text = m_Action.Length.ToString();
                // Make sure the screen has a black background
                m_Action.Background_Start = Color.Black;
                m_Action.Background_End = Color.Black;
                // re-enable the update timer, it can tick now.
                updateTimer.Enabled = true;
            }
            catch
            {
                // Something went wrong, throw an alert, and increase the errorcount
                m_ErrorCount++;
                if (m_ErrorCount >= m_MaxError)
                    killControl();
                MessageBox.Show("Error in actionClockControl, uxUpdateBtn_Click");
            }
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    // This is easy, the ActionObject takes care of calculations, just display them as long as they are there.
                    if (m_Action.StartString != "")
                    {
                        uxTTfirstStart.Text = m_Action.StartString;
                    }
                    if (m_Action.EndString != "")
                    {
                        uxTTfirstEnd.Text = m_Action.EndString;
                    }
                }
                catch
                {
                    m_ErrorCount++;
                    if (m_ErrorCount >= m_MaxError)
                        killControl();
                    MessageBox.Show("First text set error");
                }

                #region IF Statement 1 - Color Red Set Begin
                try
                {
                    // If the timer has expired, set the display to red
                    if (m_Action.StartTime.TotalSeconds >= 0)
                    {
                        m_Action.Background_Start = Color.Red;
                    }
                }
                catch
                {
                    m_ErrorCount++;
                    if (m_ErrorCount >= m_MaxError)
                        killControl();
                    MessageBox.Show("General Error in actionClockControl, updateTimer_Tick, IF statement #1");
                }
                #endregion

                #region IF Statement 2 - Blink Enable Set
                try
                {
                    // Start blinking, but not too soon to the end of the countdown
                    if ((m_Action.StartTime.TotalSeconds >= -15) && (m_Action.StartTime.TotalSeconds <= -5))
                    {
                        if (m_BlinkRunning == false)
                        {
                            m_BlinkTrack = 0;
                            blinkTimer.Enabled = true;
                        }
                    }
                }
                catch
                {
                    m_ErrorCount++;
                    if (m_ErrorCount >= m_MaxError)
                        killControl();
                    MessageBox.Show("General Error in actionClockControl, updateTimer_Tick, IF statement #2");
                }
                #endregion

                #region IF Statement 3 - Blink Disable Set
                try
                {
                    if ((m_Action.EndTime.TotalSeconds >= -15) && (m_Action.EndTime.TotalSeconds <= -5))
                    {
                        if (m_BlinkRunning == false)
                        {
                            m_BlinkTrack = 0;
                            blinkTimer.Enabled = true;
                        }
                    }
                }
                catch
                {
                    m_ErrorCount++;
                    if (m_ErrorCount >= m_MaxError)
                        killControl();
                    MessageBox.Show("General Error in actionClockControl, updateTimer_Tick, IF statement #3");
                }
                #endregion

                #region IF Statement 4 - Color Red Set End
                try
                {
                    // If the timer has expired set the display to red
                    if (m_Action.EndTime.TotalSeconds >= 0)
                    {
                        m_Action.Background_End = Color.Red;
                    }
                }
                catch
                {
                    m_ErrorCount++;
                    if (m_ErrorCount >= m_MaxError)
                        killControl();
                    MessageBox.Show("General Error in actionClockControl, updateTimer_Tick, IF statement #4");
                }
                #endregion

                #region IF Statement 5 - Blink Disable and Self Destruct
                try
                {
                    // If the stop timer has been elapsed for 1 minute or more, kill the timer
                    if (m_Action.EndTime.TotalMinutes >= 1)
                    {
                        updateTimer.Enabled = false;
                        killControl();
                    }
                }
                catch
                {
                    m_ErrorCount++;
                    if (m_ErrorCount >= m_MaxError)
                        killControl();
                    MessageBox.Show("General Error in actionClockControl, updateTimer_Tick, IF statement #5");
                }
                #endregion

                uxTTfirstStart.BackColor = m_Action.Background_Start;
                uxTTfirstEnd.BackColor = m_Action.Background_End;
            }
            catch
            {
                m_ErrorCount++;
                if (m_ErrorCount >= m_MaxError)
                    killControl();
                MessageBox.Show("General Error in actionClockControl, updateTimer_Tick");
            }
        }

        private void blinkTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Make sure we haven't blinked too much
                if (m_BlinkTrack <= 130)
                {
                    // Alternate colors every other blink
                    if ((m_BlinkTrack % 2) == 0)
                    {
                        BackColor = Color.Red;
                    }
                    else
                    {
                        BackColor = Color.Black;
                    }
                    // Tell the world we're still running, and increment the counter.
                    m_BlinkRunning = true;
                    m_BlinkTrack++;
                }
                else
                {
                    // We've run enough, set the color back to black, and turn off the timer.
                    BackColor = Color.Black;
                    m_BlinkRunning = false;
                    blinkTimer.Enabled = false;
                }
            }
            catch
            {
                m_ErrorCount++;
                if (m_ErrorCount >= m_MaxError)
                    killControl();
                MessageBox.Show("Error in actionClockControl, blinkTimer_Tick");
            }
        }

        private void uxActionStartNow_Click(object sender, EventArgs e)
        {
            try
            {
                // The user told us the action started NOW. Update the timer to reflect that.
                // The length should not change

                // Disable the main timer, or things could break
                updateTimer.Enabled = false;
                // Update the ActionObject to reflect the change
                m_Action.Update(DateTime.Now.ToString(), m_Action.Length.ToString());
                // Disable the blink timer, it is no longer correct
                blinkTimer.Enabled = false;
                // Reset the blink timer
                m_BlinkTrack = 0;
                m_BlinkRunning = false;
                // Set the background colors to black
                m_Action.Background_Start = Color.Black;
                m_Action.Background_End = Color.Black;
                // Re-enable the main timer
                updateTimer.Enabled = true;
            }
            catch
            {
                // We shouldn't hit this ever
                m_ErrorCount++;
                if (m_ErrorCount >= m_MaxError)
                    killControl();
                MessageBox.Show("Error in actionClockControl, uxActionStartNow_Click");
            }
        }

        private void uxFullTimerButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Generate a new window using THE CURRENT ActionObject, this is important if they make changes in the new window
                // Using the current object, all changes in the new window will be reflected in this timer after the new one closes.
                uxFullSingleTimer newtimer = new uxFullSingleTimer(m_Action);
                newtimer.Show();
            }
            catch
            {
                m_ErrorCount++;
                if (m_ErrorCount >= m_MaxError)
                    killControl();
                MessageBox.Show("Error in actionClockControl, uxFUllTimerButton_Click");
            }
        }

        private void uxDeleteButton_Click(object sender, EventArgs e)
        {
            // The delete button was pressed.
            killControl();
        }

        private void killControl()
        {
            // Keep all cleanup procedures in this function, and ONLY close the control using this function.

            try
            {
                // We need to figure out who owns us
                Control control = this.Parent;
                EventMessenger.SendMessage(this, m_Action, false, true);
                
                // This checks if we are the first control, if so, we need to make a new "first" control before self-destructing
                if (m_isFirst == true)
                {
                    // We need to modify the date the next show begins, it is exactly one week after this one.
                    // Make a new DateTime to help calculate it
                    DateTime modStart = m_Action.Start;
                    // It's just easier to do it this way
                    String modEnd = m_Action.Length.ToString();
                    // It's really this easy to add 7 days to a datetime? Wow!
                    modStart = modStart.AddDays(7);
                    // Re-convert it to a string to pass back to a new actionClockControl
                    String s_modStart = Convert.ToDateTime(modStart).ToString("MM/dd/yyyy hh:mm:ss tt");

                    // Here's where it starts getting screwey, create a new control
                    actionClockControl acc = new actionClockControl(s_modStart, modEnd, "YRU-Up", true);
                    // Set the parent of the control we just made to our parent
                    acc.Parent = control;
                    // And show it
                    acc.Show();
                }
                if (this.Parent.Controls.Contains(this) == true)
                {
                    // Don't dispose until we're removed from the parent
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    // We're removed from the parent, dispose.
                    this.Dispose();
                }
                // Just to make sure, dispose again. ;)
                this.Dispose();
            }
            catch
            {
                // If something in this function fails, dispose and throw a messagebox
                this.Dispose();
                MessageBox.Show("Error in actionClockControl, killControl");
            }
        }
    }
}
