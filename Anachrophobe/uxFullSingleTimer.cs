using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anachrophobe
{
    // This is used to fill the screen with a SINGLE timer.
    // 99% of the code is taken from the actionClockControl, use it as reference, and update them both at the same time.
    public partial class uxFullSingleTimer : Form
    {
        private int m_BlinkTrack;
        private bool m_BlinkRunning = false;
        private TimerDatastore m_Action;

        public uxFullSingleTimer()
        {
            InitializeComponent();
        }

        public uxFullSingleTimer(TimerDatastore inAction) : this()
        {
            // Parse all the stuff used to initialize the timer.

            m_Action = inAction;

            uxTimeOfAction.Text = m_Action.Start.ToString();
            uxEndOfAction.Text = m_Action.Length.ToString();
            uxNameLabel.Text = m_Action.Name;
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
                MessageBox.Show("Error in uxFullSingleTimer, uxUpdateBtn_Click");
            }
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                uxTTfirstStart.Text = m_Action.StartString;
                uxTTfirstEnd.Text = m_Action.EndString;
                if (m_Action.StartTime.TotalSeconds >= 0)
                {
                    m_Action.Background_Start = Color.Red;
                }

                if ((m_Action.StartTime.TotalSeconds >= -15) && (m_Action.StartTime.TotalSeconds <= -5))
                {
                    if (m_BlinkRunning == false)
                    {
                        m_BlinkTrack = 0;
                        blinkTimer.Enabled = true;
                    }
                }
                if ((m_Action.EndTime.TotalSeconds >= -15) && (m_Action.EndTime.TotalSeconds <= -5))
                {
                    if (m_BlinkRunning == false)
                    {
                        m_BlinkTrack = 0;
                        blinkTimer.Enabled = true;
                    }
                }

                if (m_Action.EndTime.TotalSeconds >= 0)
                {
                    m_Action.Background_End = Color.Red;
                }

                if (m_Action.EndTime.TotalMinutes >= 1)
                {
                    updateTimer.Enabled = false;
                    killControl();
                }
                uxTTfirstStart.BackColor = m_Action.Background_Start;
                uxTTfirstEnd.BackColor = m_Action.Background_End;
            }
            catch
            {
                MessageBox.Show("Error in uxFullSingleTimer, updateTimer_Tick");
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
                MessageBox.Show("Error in uxFullSingleTimer, blinkTimer_Tick");
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
                MessageBox.Show("Error in uxFullSingleTimer, uxActionStartNow_Click");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            killControl();
        }

        private void killControl()
        {
            try
            {
                this.Dispose();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error in uxFullSingleTimer, killControl");
            }
        }

    }
}
