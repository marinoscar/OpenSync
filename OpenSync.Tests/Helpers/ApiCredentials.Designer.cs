namespace OpenSync.Tests.Helpers
{
    partial class ApiCredentials
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.okCommand = new System.Windows.Forms.Button();
            this.cancelCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Name";
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(98, 19);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(222, 20);
            this.keyInput.TabIndex = 0;
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(98, 46);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(222, 20);
            this.userNameInput.TabIndex = 1;
            // 
            // okCommand
            // 
            this.okCommand.Location = new System.Drawing.Point(159, 83);
            this.okCommand.Name = "okCommand";
            this.okCommand.Size = new System.Drawing.Size(75, 23);
            this.okCommand.TabIndex = 2;
            this.okCommand.Text = "&Ok";
            this.okCommand.UseVisualStyleBackColor = true;
            this.okCommand.Click += new System.EventHandler(this.OkCommandClick);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(245, 83);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 3;
            this.cancelCommand.Text = "&Cancel";
            this.cancelCommand.UseVisualStyleBackColor = true;
            // 
            // ApiCredentials
            // 
            this.AcceptButton = this.okCommand;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelCommand;
            this.ClientSize = new System.Drawing.Size(340, 121);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.okCommand);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApiCredentials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Api Credentials";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Button okCommand;
        private System.Windows.Forms.Button cancelCommand;
    }
}