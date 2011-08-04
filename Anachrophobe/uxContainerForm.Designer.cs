namespace Anachrophobe
{
    partial class uxContainerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uxFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uxLengthOfAction = new System.Windows.Forms.MaskedTextBox();
            this.uxTimeOfAction = new System.Windows.Forms.MaskedTextBox();
            this.uxLicenseText = new System.Windows.Forms.Label();
            this.uxKillProgram = new System.Windows.Forms.Button();
            this.uxCurrentTime = new System.Windows.Forms.TextBox();
            this.uxNameOfAction = new System.Windows.Forms.TextBox();
            this.uxAddTimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.uxYUPmode = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxFlowPanel
            // 
            this.uxFlowPanel.AutoScroll = true;
            this.uxFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uxFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxFlowPanel.Location = new System.Drawing.Point(3, 26);
            this.uxFlowPanel.Name = "uxFlowPanel";
            this.uxFlowPanel.Size = new System.Drawing.Size(1018, 591);
            this.uxFlowPanel.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.uxLengthOfAction);
            this.panel1.Controls.Add(this.uxTimeOfAction);
            this.panel1.Controls.Add(this.uxLicenseText);
            this.panel1.Controls.Add(this.uxKillProgram);
            this.panel1.Controls.Add(this.uxCurrentTime);
            this.panel1.Controls.Add(this.uxNameOfAction);
            this.panel1.Controls.Add(this.uxAddTimer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 145);
            this.panel1.TabIndex = 12;
            // 
            // uxLengthOfAction
            // 
            this.uxLengthOfAction.BackColor = System.Drawing.Color.Black;
            this.uxLengthOfAction.ForeColor = System.Drawing.Color.White;
            this.uxLengthOfAction.Location = new System.Drawing.Point(319, 121);
            this.uxLengthOfAction.Mask = "00:00:00";
            this.uxLengthOfAction.Name = "uxLengthOfAction";
            this.uxLengthOfAction.Size = new System.Drawing.Size(135, 20);
            this.uxLengthOfAction.TabIndex = 2;
            this.uxLengthOfAction.TextChanged += new System.EventHandler(this.uxLengthOfAction_TextChanged);
            // 
            // uxTimeOfAction
            // 
            this.uxTimeOfAction.BackColor = System.Drawing.Color.Black;
            this.uxTimeOfAction.ForeColor = System.Drawing.Color.White;
            this.uxTimeOfAction.Location = new System.Drawing.Point(86, 121);
            this.uxTimeOfAction.Mask = "00/00/0000 90:00:00 AA";
            this.uxTimeOfAction.Name = "uxTimeOfAction";
            this.uxTimeOfAction.Size = new System.Drawing.Size(136, 20);
            this.uxTimeOfAction.TabIndex = 1;
            this.uxTimeOfAction.TextChanged += new System.EventHandler(this.uxTimeOfAction_TextChanged);
            // 
            // uxLicenseText
            // 
            this.uxLicenseText.AutoSize = true;
            this.uxLicenseText.Location = new System.Drawing.Point(868, 124);
            this.uxLicenseText.Name = "uxLicenseText";
            this.uxLicenseText.Size = new System.Drawing.Size(60, 13);
            this.uxLicenseText.TabIndex = 12;
            this.uxLicenseText.Text = "Unlicensed";
            // 
            // uxKillProgram
            // 
            this.uxKillProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxKillProgram.ForeColor = System.Drawing.Color.White;
            this.uxKillProgram.Location = new System.Drawing.Point(785, 119);
            this.uxKillProgram.Name = "uxKillProgram";
            this.uxKillProgram.Size = new System.Drawing.Size(77, 23);
            this.uxKillProgram.TabIndex = 99;
            this.uxKillProgram.TabStop = false;
            this.uxKillProgram.Text = "Quit";
            this.uxKillProgram.UseVisualStyleBackColor = true;
            this.uxKillProgram.Click += new System.EventHandler(this.uxKillProgram_Click);
            // 
            // uxCurrentTime
            // 
            this.uxCurrentTime.BackColor = System.Drawing.Color.Black;
            this.uxCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCurrentTime.ForeColor = System.Drawing.Color.White;
            this.uxCurrentTime.Location = new System.Drawing.Point(3, 0);
            this.uxCurrentTime.Name = "uxCurrentTime";
            this.uxCurrentTime.Size = new System.Drawing.Size(980, 110);
            this.uxCurrentTime.TabIndex = 11;
            // 
            // uxNameOfAction
            // 
            this.uxNameOfAction.BackColor = System.Drawing.Color.Black;
            this.uxNameOfAction.ForeColor = System.Drawing.Color.White;
            this.uxNameOfAction.Location = new System.Drawing.Point(548, 121);
            this.uxNameOfAction.Name = "uxNameOfAction";
            this.uxNameOfAction.Size = new System.Drawing.Size(141, 20);
            this.uxNameOfAction.TabIndex = 3;
            this.uxNameOfAction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxNameOfAction_KeyDown);
            // 
            // uxAddTimer
            // 
            this.uxAddTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxAddTimer.ForeColor = System.Drawing.Color.White;
            this.uxAddTimer.Location = new System.Drawing.Point(704, 119);
            this.uxAddTimer.Name = "uxAddTimer";
            this.uxAddTimer.Size = new System.Drawing.Size(77, 23);
            this.uxAddTimer.TabIndex = 4;
            this.uxAddTimer.Text = "Add Timer";
            this.uxAddTimer.UseVisualStyleBackColor = true;
            this.uxAddTimer.Click += new System.EventHandler(this.uxAddTimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name Of Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time of Action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Length of Action";
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // uxYUPmode
            // 
            this.uxYUPmode.AutoSize = true;
            this.uxYUPmode.Location = new System.Drawing.Point(3, 3);
            this.uxYUPmode.Name = "uxYUPmode";
            this.uxYUPmode.Size = new System.Drawing.Size(96, 17);
            this.uxYUPmode.TabIndex = 5;
            this.uxYUPmode.Text = "YRU-Up Mode";
            this.uxYUPmode.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.uxYUPmode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxFlowPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 620);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // uxContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 765);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uxContainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action Countdown Timer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button uxKillProgram;
        private System.Windows.Forms.Button uxAddTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxNameOfAction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxCurrentTime;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uxLicenseText;
        private System.Windows.Forms.FlowLayoutPanel uxFlowPanel;
        private System.Windows.Forms.CheckBox uxYUPmode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox uxTimeOfAction;
        private System.Windows.Forms.MaskedTextBox uxLengthOfAction;
    }
}

