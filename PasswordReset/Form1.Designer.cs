namespace PasswordReset
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
            this.lPrevPW = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbRepeat = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lUserID = new System.Windows.Forms.Label();
            this.lAdmin = new System.Windows.Forms.Label();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.lWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lPrevPW
            // 
            this.lPrevPW.AutoSize = true;
            this.lPrevPW.Location = new System.Drawing.Point(25, 68);
            this.lPrevPW.Name = "lPrevPW";
            this.lPrevPW.Size = new System.Drawing.Size(97, 13);
            this.lPrevPW.TabIndex = 0;
            this.lPrevPW.Text = "Previous Password";
            this.lPrevPW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(128, 92);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(100, 20);
            this.tbNewPassword.TabIndex = 1;
            // 
            // tbRepeat
            // 
            this.tbRepeat.Location = new System.Drawing.Point(128, 118);
            this.tbRepeat.Name = "tbRepeat";
            this.tbRepeat.PasswordChar = '*';
            this.tbRepeat.Size = new System.Drawing.Size(100, 20);
            this.tbRepeat.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(153, 189);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(72, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(128, 39);
            this.tbUser.Name = "tbUser";
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 5;
            // 
            // lUserID
            // 
            this.lUserID.AutoSize = true;
            this.lUserID.Location = new System.Drawing.Point(80, 43);
            this.lUserID.Name = "lUserID";
            this.lUserID.Size = new System.Drawing.Size(43, 13);
            this.lUserID.TabIndex = 8;
            this.lUserID.Text = "User ID";
            this.lUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lAdmin
            // 
            this.lAdmin.AutoSize = true;
            this.lAdmin.Location = new System.Drawing.Point(34, 17);
            this.lAdmin.Name = "lAdmin";
            this.lAdmin.Size = new System.Drawing.Size(102, 13);
            this.lAdmin.TabIndex = 10;
            this.lAdmin.Text = "Administrative Mode";
            this.lAdmin.Visible = false;
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(128, 65);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.PasswordChar = '*';
            this.tbOldPass.Size = new System.Drawing.Size(100, 20);
            this.tbOldPass.TabIndex = 0;
            // 
            // lWarning
            // 
            this.lWarning.Location = new System.Drawing.Point(42, 152);
            this.lWarning.Name = "lWarning";
            this.lWarning.Size = new System.Drawing.Size(186, 34);
            this.lWarning.TabIndex = 11;
            this.lWarning.Text = "You will be logged out of Windows! Close all programs first!";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 237);
            this.Controls.Add(this.lWarning);
            this.Controls.Add(this.tbOldPass);
            this.Controls.Add(this.lAdmin);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lUserID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbRepeat);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lPrevPW);
            this.Name = "Form1";
            this.Text = "Password Reset";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPrevPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbRepeat;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lUserID;
        private System.Windows.Forms.Label lAdmin;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.Label lWarning;
    }
}

