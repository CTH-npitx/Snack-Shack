namespace LoginApplication
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnClose = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtSecAnswer = new System.Windows.Forms.TextBox();
            this.txtUserError = new System.Windows.Forms.TextBox();
            this.txtPasswordError = new System.Windows.Forms.TextBox();
            this.txtConfirmError = new System.Windows.Forms.TextBox();
            this.txtQuestionWarn = new System.Windows.Forms.TextBox();
            this.txtAnswerWarn = new System.Windows.Forms.TextBox();
            this.txt_debugInfo = new System.Windows.Forms.TextBox();
            this.lblCountSecQuest = new System.Windows.Forms.Label();
            this.lbl_secAns = new System.Windows.Forms.Label();
            this.cmbSecQuest = new System.Windows.Forms.ComboBox();
            this.lbl_SeqQuest = new System.Windows.Forms.Label();
            this.lst_userID = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(421, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 44);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(31, 33);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(263, 33);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(118, 20);
            this.txtConfirmPass.TabIndex = 3;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(137, 33);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(120, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(31, 7);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(57, 19);
            this.lbl_UserID.TabIndex = 4;
            this.lbl_UserID.Text = "User ID";
            this.lbl_UserID.Click += new System.EventHandler(this.lbl_UserID_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(263, 7);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(123, 19);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.Click += new System.EventHandler(this.lblConfirmPassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(159, 7);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 19);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.FlatAppearance.BorderSize = 2;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(421, 57);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 44);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtSecAnswer
            // 
            this.txtSecAnswer.Location = new System.Drawing.Point(31, 277);
            this.txtSecAnswer.Name = "txtSecAnswer";
            this.txtSecAnswer.Size = new System.Drawing.Size(157, 20);
            this.txtSecAnswer.TabIndex = 6;
            this.txtSecAnswer.TextChanged += new System.EventHandler(this.txtSecAnswer_TextChanged);
            // 
            // txtUserError
            // 
            this.txtUserError.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserError.Enabled = false;
            this.txtUserError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserError.Location = new System.Drawing.Point(31, 59);
            this.txtUserError.Name = "txtUserError";
            this.txtUserError.Size = new System.Drawing.Size(100, 13);
            this.txtUserError.TabIndex = 11;
            this.txtUserError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserError.TextChanged += new System.EventHandler(this.txtUserError_TextChanged);
            // 
            // txtPasswordError
            // 
            this.txtPasswordError.BackColor = System.Drawing.SystemColors.Control;
            this.txtPasswordError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordError.Enabled = false;
            this.txtPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordError.Location = new System.Drawing.Point(137, 58);
            this.txtPasswordError.Name = "txtPasswordError";
            this.txtPasswordError.Size = new System.Drawing.Size(120, 13);
            this.txtPasswordError.TabIndex = 12;
            this.txtPasswordError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswordError.TextChanged += new System.EventHandler(this.txtPasswordError_TextChanged);
            // 
            // txtConfirmError
            // 
            this.txtConfirmError.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirmError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmError.Enabled = false;
            this.txtConfirmError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmError.Location = new System.Drawing.Point(263, 57);
            this.txtConfirmError.Name = "txtConfirmError";
            this.txtConfirmError.Size = new System.Drawing.Size(118, 13);
            this.txtConfirmError.TabIndex = 13;
            this.txtConfirmError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmError.TextChanged += new System.EventHandler(this.txtConfirmError_TextChanged);
            // 
            // txtQuestionWarn
            // 
            this.txtQuestionWarn.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuestionWarn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestionWarn.Enabled = false;
            this.txtQuestionWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestionWarn.Location = new System.Drawing.Point(290, 179);
            this.txtQuestionWarn.Name = "txtQuestionWarn";
            this.txtQuestionWarn.Size = new System.Drawing.Size(174, 13);
            this.txtQuestionWarn.TabIndex = 14;
            this.txtQuestionWarn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuestionWarn.TextChanged += new System.EventHandler(this.txtQuestionWarn_TextChanged);
            // 
            // txtAnswerWarn
            // 
            this.txtAnswerWarn.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnswerWarn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswerWarn.Enabled = false;
            this.txtAnswerWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswerWarn.Location = new System.Drawing.Point(212, 284);
            this.txtAnswerWarn.Multiline = true;
            this.txtAnswerWarn.Name = "txtAnswerWarn";
            this.txtAnswerWarn.Size = new System.Drawing.Size(149, 40);
            this.txtAnswerWarn.TabIndex = 15;
            this.txtAnswerWarn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnswerWarn.TextChanged += new System.EventHandler(this.txtAnswerWarn_TextChanged);
            // 
            // txt_debugInfo
            // 
            this.txt_debugInfo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_debugInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_debugInfo.Location = new System.Drawing.Point(582, 255);
            this.txt_debugInfo.Multiline = true;
            this.txt_debugInfo.Name = "txt_debugInfo";
            this.txt_debugInfo.ReadOnly = true;
            this.txt_debugInfo.Size = new System.Drawing.Size(206, 183);
            this.txt_debugInfo.TabIndex = 0;
            this.txt_debugInfo.TabStop = false;
            this.txt_debugInfo.Visible = false;
            this.txt_debugInfo.TextChanged += new System.EventHandler(this.txt_debugInfo_TextChanged);
            // 
            // lblCountSecQuest
            // 
            this.lblCountSecQuest.AutoSize = true;
            this.lblCountSecQuest.BackColor = System.Drawing.SystemColors.Control;
            this.lblCountSecQuest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCountSecQuest.Location = new System.Drawing.Point(571, 195);
            this.lblCountSecQuest.Name = "lblCountSecQuest";
            this.lblCountSecQuest.Size = new System.Drawing.Size(13, 13);
            this.lblCountSecQuest.TabIndex = 16;
            this.lblCountSecQuest.Text = "0";
            this.lblCountSecQuest.UseMnemonic = false;
            this.lblCountSecQuest.Visible = false;
            this.lblCountSecQuest.Click += new System.EventHandler(this.lblCountSecQuest_Click);
            // 
            // lbl_secAns
            // 
            this.lbl_secAns.AutoSize = true;
            this.lbl_secAns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_secAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secAns.Location = new System.Drawing.Point(31, 255);
            this.lbl_secAns.Name = "lbl_secAns";
            this.lbl_secAns.Size = new System.Drawing.Size(111, 19);
            this.lbl_secAns.TabIndex = 19;
            this.lbl_secAns.Text = "Security Answer";
            // 
            // cmbSecQuest
            // 
            this.cmbSecQuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecQuest.FormattingEnabled = true;
            this.cmbSecQuest.Items.AddRange(new object[] {
            "What is your Social Security Number",
            "DOD identification card number",
            "Your full legal name",
            "Your mothers maiden name",
            "Your full date of birth",
            "Your credit score",
            "You credit card number",
            "You debit card number",
            "Your ATM pin"});
            this.cmbSecQuest.Location = new System.Drawing.Point(31, 176);
            this.cmbSecQuest.Name = "cmbSecQuest";
            this.cmbSecQuest.Size = new System.Drawing.Size(226, 21);
            this.cmbSecQuest.TabIndex = 5;
            this.cmbSecQuest.SelectedIndexChanged += new System.EventHandler(this.cmbSecQuest_SelectedIndexChanged);
            // 
            // lbl_SeqQuest
            // 
            this.lbl_SeqQuest.AutoSize = true;
            this.lbl_SeqQuest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SeqQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SeqQuest.Location = new System.Drawing.Point(31, 154);
            this.lbl_SeqQuest.Name = "lbl_SeqQuest";
            this.lbl_SeqQuest.Size = new System.Drawing.Size(122, 19);
            this.lbl_SeqQuest.TabIndex = 18;
            this.lbl_SeqQuest.Text = "Security Question";
            // 
            // lst_userID
            // 
            this.lst_userID.FormattingEnabled = true;
            this.lst_userID.Location = new System.Drawing.Point(582, 6);
            this.lst_userID.Name = "lst_userID";
            this.lst_userID.Size = new System.Drawing.Size(206, 121);
            this.lst_userID.TabIndex = 20;
            this.lst_userID.TabStop = false;
            this.lst_userID.UseTabStops = false;
            this.lst_userID.Visible = false;
            this.lst_userID.SelectedIndexChanged += new System.EventHandler(this.lst_userID_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lst_userID);
            this.Controls.Add(this.lbl_SeqQuest);
            this.Controls.Add(this.lbl_secAns);
            this.Controls.Add(this.cmbSecQuest);
            this.Controls.Add(this.txtSecAnswer);
            this.Controls.Add(this.lblCountSecQuest);
            this.Controls.Add(this.txtAnswerWarn);
            this.Controls.Add(this.txt_debugInfo);
            this.Controls.Add(this.txtQuestionWarn);
            this.Controls.Add(this.txtConfirmError);
            this.Controls.Add(this.txtPasswordError);
            this.Controls.Add(this.txtUserError);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lbl_UserID);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnClose);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtSecAnswer;
        private System.Windows.Forms.TextBox txtUserError;
        private System.Windows.Forms.TextBox txtPasswordError;
        private System.Windows.Forms.TextBox txtConfirmError;
        private System.Windows.Forms.TextBox txtQuestionWarn;
        private System.Windows.Forms.TextBox txtAnswerWarn;
        private System.Windows.Forms.TextBox txt_debugInfo;
        private System.Windows.Forms.Label lblCountSecQuest;
        private System.Windows.Forms.Label lbl_secAns;
        private System.Windows.Forms.ComboBox cmbSecQuest;
        private System.Windows.Forms.Label lbl_SeqQuest;
        private System.Windows.Forms.ListBox lst_userID;
        private System.Windows.Forms.TextBox textBox1;
    }
}

