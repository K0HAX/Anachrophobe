namespace Anachrophobe
{
    partial class actionClockControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uxTTfirstEnd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.uxTTfirstStart = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uxTimeOfAction = new System.Windows.Forms.TextBox();
            this.uxUpdateBtn = new System.Windows.Forms.Button();
            this.uxEndOfAction = new System.Windows.Forms.TextBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.blinkTimer = new System.Windows.Forms.Timer(this.components);
            this.uxActionStartNow = new System.Windows.Forms.Button();
            this.uxFullTimerButton = new System.Windows.Forms.Button();
            this.uxDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTTfirstEnd
            // 
            this.uxTTfirstEnd.BackColor = System.Drawing.Color.Black;
            this.uxTTfirstEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTTfirstEnd.ForeColor = System.Drawing.Color.White;
            this.uxTTfirstEnd.Location = new System.Drawing.Point(3, 166);
            this.uxTTfirstEnd.Name = "uxTTfirstEnd";
            this.uxTTfirstEnd.Size = new System.Drawing.Size(267, 62);
            this.uxTTfirstEnd.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-7, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(260, 46);
            this.label11.TabIndex = 11;
            this.label11.Text = "End of Action";
            // 
            // uxTTfirstStart
            // 
            this.uxTTfirstStart.BackColor = System.Drawing.Color.Black;
            this.uxTTfirstStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTTfirstStart.ForeColor = System.Drawing.Color.White;
            this.uxTTfirstStart.Location = new System.Drawing.Point(0, 58);
            this.uxTTfirstStart.Name = "uxTTfirstStart";
            this.uxTTfirstStart.Size = new System.Drawing.Size(267, 62);
            this.uxTTfirstStart.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-4, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Time to Action";
            // 
            // uxTimeOfAction
            // 
            this.uxTimeOfAction.BackColor = System.Drawing.Color.Black;
            this.uxTimeOfAction.ForeColor = System.Drawing.Color.White;
            this.uxTimeOfAction.Location = new System.Drawing.Point(3, 233);
            this.uxTimeOfAction.Name = "uxTimeOfAction";
            this.uxTimeOfAction.Size = new System.Drawing.Size(94, 20);
            this.uxTimeOfAction.TabIndex = 13;
            // 
            // uxUpdateBtn
            // 
            this.uxUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxUpdateBtn.Location = new System.Drawing.Point(203, 231);
            this.uxUpdateBtn.Name = "uxUpdateBtn";
            this.uxUpdateBtn.Size = new System.Drawing.Size(75, 21);
            this.uxUpdateBtn.TabIndex = 15;
            this.uxUpdateBtn.Text = "Update!";
            this.uxUpdateBtn.UseVisualStyleBackColor = true;
            this.uxUpdateBtn.Click += new System.EventHandler(this.uxUpdateBtn_Click);
            // 
            // uxEndOfAction
            // 
            this.uxEndOfAction.BackColor = System.Drawing.Color.Black;
            this.uxEndOfAction.ForeColor = System.Drawing.Color.White;
            this.uxEndOfAction.Location = new System.Drawing.Point(103, 233);
            this.uxEndOfAction.Name = "uxEndOfAction";
            this.uxEndOfAction.Size = new System.Drawing.Size(94, 20);
            this.uxEndOfAction.TabIndex = 14;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNameLabel.Location = new System.Drawing.Point(-3, 1);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(107, 31);
            this.uxNameLabel.TabIndex = 16;
            this.uxNameLabel.Text = "Untitled";
            // 
            // blinkTimer
            // 
            this.blinkTimer.Tick += new System.EventHandler(this.blinkTimer_Tick);
            // 
            // uxActionStartNow
            // 
            this.uxActionStartNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxActionStartNow.Location = new System.Drawing.Point(152, 32);
            this.uxActionStartNow.Name = "uxActionStartNow";
            this.uxActionStartNow.Size = new System.Drawing.Size(126, 23);
            this.uxActionStartNow.TabIndex = 16;
            this.uxActionStartNow.Text = "Reset start to NOW";
            this.uxActionStartNow.UseVisualStyleBackColor = true;
            this.uxActionStartNow.Click += new System.EventHandler(this.uxActionStartNow_Click);
            // 
            // uxFullTimerButton
            // 
            this.uxFullTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxFullTimerButton.Location = new System.Drawing.Point(4, 260);
            this.uxFullTimerButton.Name = "uxFullTimerButton";
            this.uxFullTimerButton.Size = new System.Drawing.Size(112, 23);
            this.uxFullTimerButton.TabIndex = 17;
            this.uxFullTimerButton.Text = "Open in full screen";
            this.uxFullTimerButton.UseVisualStyleBackColor = true;
            this.uxFullTimerButton.Click += new System.EventHandler(this.uxFullTimerButton_Click);
            // 
            // uxDeleteButton
            // 
            this.uxDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxDeleteButton.Location = new System.Drawing.Point(192, 260);
            this.uxDeleteButton.Name = "uxDeleteButton";
            this.uxDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.uxDeleteButton.TabIndex = 18;
            this.uxDeleteButton.Text = "Delete Timer";
            this.uxDeleteButton.UseVisualStyleBackColor = true;
            this.uxDeleteButton.Click += new System.EventHandler(this.uxDeleteButton_Click);
            // 
            // actionClockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.uxDeleteButton);
            this.Controls.Add(this.uxFullTimerButton);
            this.Controls.Add(this.uxActionStartNow);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxEndOfAction);
            this.Controls.Add(this.uxUpdateBtn);
            this.Controls.Add(this.uxTimeOfAction);
            this.Controls.Add(this.uxTTfirstEnd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.uxTTfirstStart);
            this.Controls.Add(this.label12);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "actionClockControl";
            this.Size = new System.Drawing.Size(281, 298);
            this.Load += new System.EventHandler(this.actionClockControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTTfirstEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox uxTTfirstStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uxTimeOfAction;
        private System.Windows.Forms.Button uxUpdateBtn;
        private System.Windows.Forms.TextBox uxEndOfAction;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.Timer blinkTimer;
        private System.Windows.Forms.Button uxActionStartNow;
        private System.Windows.Forms.Button uxFullTimerButton;
        private System.Windows.Forms.Button uxDeleteButton;
    }
}
