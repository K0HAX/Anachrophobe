namespace Anachrophobe
{
    partial class uxFullSingleTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.blinkTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.uxTTfirstEnd = new System.Windows.Forms.TextBox();
            this.uxActionStartNow = new System.Windows.Forms.Button();
            this.uxTimeOfAction = new System.Windows.Forms.TextBox();
            this.uxTTfirstStart = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uxEndOfAction = new System.Windows.Forms.TextBox();
            this.uxUpdateBtn = new System.Windows.Forms.Button();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // blinkTimer
            // 
            this.blinkTimer.Tick += new System.EventHandler(this.blinkTimer_Tick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(17, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "Exit Full Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(260, 46);
            this.label11.TabIndex = 20;
            this.label11.Text = "End of Action";
            // 
            // uxTTfirstEnd
            // 
            this.uxTTfirstEnd.BackColor = System.Drawing.Color.Black;
            this.uxTTfirstEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTTfirstEnd.ForeColor = System.Drawing.Color.White;
            this.uxTTfirstEnd.Location = new System.Drawing.Point(300, 300);
            this.uxTTfirstEnd.Name = "uxTTfirstEnd";
            this.uxTTfirstEnd.Size = new System.Drawing.Size(712, 116);
            this.uxTTfirstEnd.TabIndex = 21;
            // 
            // uxActionStartNow
            // 
            this.uxActionStartNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxActionStartNow.Location = new System.Drawing.Point(168, 78);
            this.uxActionStartNow.Name = "uxActionStartNow";
            this.uxActionStartNow.Size = new System.Drawing.Size(145, 40);
            this.uxActionStartNow.TabIndex = 25;
            this.uxActionStartNow.Text = "Reset start to NOW";
            this.uxActionStartNow.UseVisualStyleBackColor = true;
            this.uxActionStartNow.Click += new System.EventHandler(this.uxActionStartNow_Click);
            // 
            // uxTimeOfAction
            // 
            this.uxTimeOfAction.BackColor = System.Drawing.Color.Black;
            this.uxTimeOfAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTimeOfAction.ForeColor = System.Drawing.Color.White;
            this.uxTimeOfAction.Location = new System.Drawing.Point(12, 718);
            this.uxTimeOfAction.Name = "uxTimeOfAction";
            this.uxTimeOfAction.Size = new System.Drawing.Size(375, 44);
            this.uxTimeOfAction.TabIndex = 22;
            // 
            // uxTTfirstStart
            // 
            this.uxTTfirstStart.BackColor = System.Drawing.Color.Black;
            this.uxTTfirstStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTTfirstStart.ForeColor = System.Drawing.Color.White;
            this.uxTTfirstStart.Location = new System.Drawing.Point(300, 121);
            this.uxTTfirstStart.Name = "uxTTfirstStart";
            this.uxTTfirstStart.Size = new System.Drawing.Size(712, 116);
            this.uxTTfirstStart.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(277, 46);
            this.label12.TabIndex = 18;
            this.label12.Text = "Time to Action";
            // 
            // uxEndOfAction
            // 
            this.uxEndOfAction.BackColor = System.Drawing.Color.Black;
            this.uxEndOfAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEndOfAction.ForeColor = System.Drawing.Color.White;
            this.uxEndOfAction.Location = new System.Drawing.Point(393, 718);
            this.uxEndOfAction.Name = "uxEndOfAction";
            this.uxEndOfAction.Size = new System.Drawing.Size(375, 44);
            this.uxEndOfAction.TabIndex = 23;
            // 
            // uxUpdateBtn
            // 
            this.uxUpdateBtn.Location = new System.Drawing.Point(774, 718);
            this.uxUpdateBtn.Name = "uxUpdateBtn";
            this.uxUpdateBtn.Size = new System.Drawing.Size(127, 44);
            this.uxUpdateBtn.TabIndex = 24;
            this.uxUpdateBtn.Text = "Update!";
            this.uxUpdateBtn.UseVisualStyleBackColor = true;
            this.uxUpdateBtn.Click += new System.EventHandler(this.uxUpdateBtn_Click);
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNameLabel.Location = new System.Drawing.Point(12, 9);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(186, 55);
            this.uxNameLabel.TabIndex = 17;
            this.uxNameLabel.Text = "Untitled";
            // 
            // uxFullSingleTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.uxEndOfAction);
            this.Controls.Add(this.uxUpdateBtn);
            this.Controls.Add(this.uxTimeOfAction);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxTTfirstEnd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.uxTTfirstStart);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxActionStartNow);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uxFullSingleTimer";
            this.Text = "uxFullSingleTimer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Timer blinkTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox uxTTfirstEnd;
        private System.Windows.Forms.Button uxActionStartNow;
        private System.Windows.Forms.TextBox uxTimeOfAction;
        private System.Windows.Forms.TextBox uxTTfirstStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uxEndOfAction;
        private System.Windows.Forms.Button uxUpdateBtn;
        private System.Windows.Forms.Label uxNameLabel;
    }
}