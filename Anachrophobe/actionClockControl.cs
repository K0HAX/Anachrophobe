using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Anachrophobe
{
    public partial class actionClockControl : UserControl
    {
        private int m_BlinkTrack;
        private bool m_BlinkRunning = false;
        private bool m_isFirst = false;
        ActionObject m_Action;
        private int m_ErrorCount;
        private static int m_MaxError = 3;

        public actionClockControl()
        {
            InitializeComponent();
        }

        public actionClockControl(string initStartTime, string initEndTime, string initName) : this()
        {
            m_ErrorCount = 0;
            Match matchStart = Regex.Match(initStartTime, @"[0-9][0-9]/[0-9][0-9]/[0-9][0-9][0-9][0-9] [0-9][0-9]:[0-9][0-9]:[0-9][0-9] s?([ap]m)?$", RegexOptions.IgnoreCase);
            Match matchLength = Regex.Match(initEndTime, @"[0-9][0-9]:[0-9][0-9]:[0-9][0-9]$", RegexOptions.IgnoreCase);

            if((matchStart.Success == false) || (matchLength.Success == false) || (initName == ""))
            {
                m_Action = new ActionObject(System.DateTime.Now.ToString(), "00:00:01", "ERROR");
            }
            else
            {
                m_Action = new ActionObject(initStartTime, initEndTime, initName);
            }
            // Parse all the stuff used to initialize the timer.
            
            //uxTimeOfAction.Text = m_Action.Start.ToString();
            uxTimeOfAction.Text = Convert.ToDateTime(m_Action.Start).ToString("MM/dd/yyyy hh:mm:ss tt");

            uxEndOfAction.Text = m_Action.Length.ToString();
            uxNameLabel.Text = m_Action.Name;
        }

        public actionClockControl(string initStartTime, string initEndTime, string initName, bool isFirst) : this()
        {
            m_ErrorCount = 0;
            Match matchStart = Regex.Match(initStartTime, @"[0-9][0-9]/[0-9][0-9]/[0-9][0-9][0-9][0-9] [0-9][0-9]:[0-9][0-9]:[0-9][0-9] s?([ap]m)?$", RegexOptions.IgnoreCase);
            Match matchLength = Regex.Match(initEndTime, @"[0-9][0-9]:[0-9][0-9]:[0-9][0-9]$", RegexOptions.IgnoreCase);

            if ((matchStart.Success == false) || (matchLength.Success == false) || (initName == ""))
            {
                m_Action = new ActionObject(System.DateTime.Now.ToString(), "00:00:01", "ERROR");
            }
            else
            {
                m_Action = new ActionObject(initStartTime, initEndTime, initName);
            }
            // Parse all the stuff used to initialize the timer.
            

            uxTimeOfAction.Text = m_Action.Start.ToString();
            uxEndOfAction.Text = m_Action.Length.ToString();
            uxNameLabel.Text = m_Action.Name;
            if (isFirst == true)
                m_isFirst = true;
        }

        private void actionClockControl_Load(object sender, EventArgs e)
        {

        }

        private void uxUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                updateTimer.Enabled = false;
                m_Action.Update(uxTimeOfAction.Text, uxEndOfAction.Text);
                blinkTimer.Enabled = false;
                m_BlinkTrack = 0;
                m_BlinkRunning = false;
                uxTimeOfAction.Text = m_Action.Start.ToString();
                uxEndOfAction.Text = m_Action.Length.ToString();
                m_Action.Background_Start = Color.Black;
                m_Action.Background_End = Color.Black;
                updateTimer.Enabled = true;
            }
            catch
            {
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

                #region IF Statement 1 - Color Red Set
                try
                {
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

                #region IF Statement 4 - Color Red Set
                try
                {
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
                if (m_BlinkTrack <= 130)
                {
                    if ((m_BlinkTrack % 2) == 0)
                    {
                        BackColor = Color.Red;
                    }
                    else
                    {
                        BackColor = Color.Black;
                    }
                    m_BlinkRunning = true;
                    m_BlinkTrack++;
                }
                else
                {
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
                updateTimer.Enabled = false;
                m_Action.Update(DateTime.Now.ToString(), m_Action.Length.ToString());
                blinkTimer.Enabled = false;
                m_BlinkTrack = 0;
                m_BlinkRunning = false;
                updateTimer.Enabled = true;
                m_Action.Background_Start = Color.Black;
                m_Action.Background_End = Color.Black;
                updateTimer.Enabled = true;
            }
            catch
            {
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
            killControl();
        }

        private void killControl()
        {
            try
            {
                Control control = this.Parent;
                if (m_isFirst == true)
                {
                    DateTime modStart = m_Action.Start;
                    String modEnd = m_Action.Length.ToString();
                    modStart = modStart.AddDays(7);
                    String s_modStart = Convert.ToDateTime(modStart).ToString("MM/dd/yyyy hh:mm:ss tt");
                    actionClockControl acc = new actionClockControl(s_modStart, modEnd, "YRU-Up", true);
                    acc.Parent = control;
                    acc.Show();
                }
                if (this.Parent.Controls.Contains(this) == true)
                {
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    this.Dispose();
                }
                this.Dispose();
            }
            catch
            {
                this.Dispose();
                MessageBox.Show("Error in actionClockControl, killControl");
            }
        }
    }
}
