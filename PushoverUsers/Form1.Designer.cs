namespace PushoverUsers
{
    partial class Form1
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
            this.uxUsersListBox = new System.Windows.Forms.CheckedListBox();
            this.uxNewUserTxt = new System.Windows.Forms.TextBox();
            this.uxAddBtn = new System.Windows.Forms.Button();
            this.uxDeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxUsersListBox
            // 
            this.uxUsersListBox.FormattingEnabled = true;
            this.uxUsersListBox.Location = new System.Drawing.Point(12, 12);
            this.uxUsersListBox.Name = "uxUsersListBox";
            this.uxUsersListBox.Size = new System.Drawing.Size(386, 94);
            this.uxUsersListBox.TabIndex = 0;
            // 
            // uxNewUserTxt
            // 
            this.uxNewUserTxt.Location = new System.Drawing.Point(12, 141);
            this.uxNewUserTxt.Name = "uxNewUserTxt";
            this.uxNewUserTxt.Size = new System.Drawing.Size(386, 20);
            this.uxNewUserTxt.TabIndex = 1;
            // 
            // uxAddBtn
            // 
            this.uxAddBtn.Location = new System.Drawing.Point(12, 167);
            this.uxAddBtn.Name = "uxAddBtn";
            this.uxAddBtn.Size = new System.Drawing.Size(75, 23);
            this.uxAddBtn.TabIndex = 2;
            this.uxAddBtn.Text = "Add";
            this.uxAddBtn.UseVisualStyleBackColor = true;
            this.uxAddBtn.Click += new System.EventHandler(this.uxAddBtn_Click);
            // 
            // uxDeleteBtn
            // 
            this.uxDeleteBtn.Location = new System.Drawing.Point(12, 112);
            this.uxDeleteBtn.Name = "uxDeleteBtn";
            this.uxDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.uxDeleteBtn.TabIndex = 3;
            this.uxDeleteBtn.Text = "Delete";
            this.uxDeleteBtn.UseVisualStyleBackColor = true;
            this.uxDeleteBtn.Click += new System.EventHandler(this.uxDeleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 238);
            this.Controls.Add(this.uxDeleteBtn);
            this.Controls.Add(this.uxAddBtn);
            this.Controls.Add(this.uxNewUserTxt);
            this.Controls.Add(this.uxUsersListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox uxUsersListBox;
        private System.Windows.Forms.TextBox uxNewUserTxt;
        private System.Windows.Forms.Button uxAddBtn;
        private System.Windows.Forms.Button uxDeleteBtn;
    }
}

