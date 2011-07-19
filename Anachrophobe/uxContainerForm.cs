using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Anachrophobe
{
    public partial class uxContainerForm : Form
    {
        Point m_ScreenBounds;

        public uxContainerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder licenseText = new StringBuilder();
            licenseText.Append("Standard GPL License");
            uxLicenseText.Text = licenseText.ToString();
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            m_ScreenBounds.X = this.Height - 281;
            m_ScreenBounds.Y = this.Width - 893;
            
            //the following line is for the MASTER branch only.
            //uxYUPmode.Dispose();
        }

        private void uxKillProgram_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void uxAddTimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxFlowPanel.Controls.Count == 0)
                {
                    if (uxYUPmode.Checked == true)
                    {
                        actionClockControl scc = new actionClockControl(uxTimeOfAction.Text, uxLengthOfAction.Text, uxNameOfAction.Text, true);
                        scc.Parent = uxFlowPanel;
                        scc.Show();
                    }
                    else
                    {
                        actionClockControl scc = new actionClockControl(uxTimeOfAction.Text, uxLengthOfAction.Text, uxNameOfAction.Text);
                        scc.Parent = uxFlowPanel;
                        scc.Show();
                    }
                }
                else
                {
                    actionClockControl scc = new actionClockControl(uxTimeOfAction.Text, uxLengthOfAction.Text, uxNameOfAction.Text);
                    scc.Parent = uxFlowPanel;
                    scc.Show();
                }
                uxTimeOfAction.Text = "";
                uxNameOfAction.Text = "";
                uxLengthOfAction.Text = "";
                uxTimeOfAction.Focus();
            }
            catch
            {
                MessageBox.Show("Error in uxContainerForm, uxAddTimer_Click");
            }

        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                uxCurrentTime.Text = DateTime.Now.ToString();
            }
            catch
            {
                MessageBox.Show("Error in uxContainerForm, ClockTimer_Tick");
            }
        }

        private void uxTimeOfAction_TextChanged(object sender, EventArgs e)
        {
            if (uxTimeOfAction.MaskFull)
            {
                uxLengthOfAction.Focus();
            }
        }

        private void uxLengthOfAction_TextChanged(object sender, EventArgs e)
        {
            if (uxLengthOfAction.MaskFull)
            {
                uxNameOfAction.Focus();
            }
        }

        void uxNameOfAction_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //MessageBox.Show("Button: " + e.KeyData.ToString());
            if (e.KeyValue == 13)
            {
                try
                {
                    if (uxFlowPanel.Controls.Count == 0)
                    {
                        if (uxYUPmode.Checked == true)
                        {
                            actionClockControl scc = new actionClockControl(uxTimeOfAction.Text, uxLengthOfAction.Text, uxNameOfAction.Text, true);
                            scc.Parent = uxFlowPanel;
                            scc.Show();
                        }
                        else
                        {
                            actionClockControl scc = new actionClockControl(uxTimeOfAction.Text, uxLengthOfAction.Text, uxNameOfAction.Text);
                            scc.Parent = uxFlowPanel;
                            scc.Show();
                        }
                    }
                    else
                    {
                        actionClockControl scc = new actionClockControl(uxTimeOfAction.Text, uxLengthOfAction.Text, uxNameOfAction.Text);
                        scc.Parent = uxFlowPanel;
                        scc.Show();
                    }
                    uxTimeOfAction.Text = "";
                    uxNameOfAction.Text = "";
                    uxLengthOfAction.Text = "";
                    uxTimeOfAction.Focus();
                }
                catch
                {
                    MessageBox.Show("Error in uxContainerForm, uxNameOfAction_KeyPressed");
                }
                //e.Handled = true;
            }
            else
            {
                //e.Handled = false;
            }
        }
    }
}
