namespace OnlineSchool
{
    partial class Registration
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
            this.LogIn = new System.Windows.Forms.GroupBox();
            this.chkLogInShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblLogInPassword = new System.Windows.Forms.Label();
            this.txtLogInPassword = new System.Windows.Forms.TextBox();
            this.txtLogInEmail = new System.Windows.Forms.TextBox();
            this.lblLogInEmail = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.GroupBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.chkSignUpShowPassword = new System.Windows.Forms.CheckBox();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtSignUpPassword = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtSignUpEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.LogIn.SuspendLayout();
            this.SignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.Controls.Add(this.chkLogInShowPassword);
            this.LogIn.Controls.Add(this.btnLogIn);
            this.LogIn.Controls.Add(this.lblLogInPassword);
            this.LogIn.Controls.Add(this.txtLogInPassword);
            this.LogIn.Controls.Add(this.txtLogInEmail);
            this.LogIn.Controls.Add(this.lblLogInEmail);
            this.LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.Location = new System.Drawing.Point(30, 120);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(391, 184);
            this.LogIn.TabIndex = 0;
            this.LogIn.TabStop = false;
            this.LogIn.Text = "Log In";
            // 
            // chkLogInShowPassword
            // 
            this.chkLogInShowPassword.AutoSize = true;
            this.chkLogInShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLogInShowPassword.Location = new System.Drawing.Point(259, 82);
            this.chkLogInShowPassword.Name = "chkLogInShowPassword";
            this.chkLogInShowPassword.Size = new System.Drawing.Size(126, 21);
            this.chkLogInShowPassword.TabIndex = 5;
            this.chkLogInShowPassword.Text = "Show Password";
            this.chkLogInShowPassword.UseVisualStyleBackColor = true;
            this.chkLogInShowPassword.CheckedChanged += new System.EventHandler(this.chkLogInShowPassword_CheckedChanged);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(140, 130);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(108, 30);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblLogInPassword
            // 
            this.lblLogInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInPassword.Location = new System.Drawing.Point(10, 80);
            this.lblLogInPassword.Name = "lblLogInPassword";
            this.lblLogInPassword.Size = new System.Drawing.Size(77, 24);
            this.lblLogInPassword.TabIndex = 3;
            this.lblLogInPassword.Text = "Password : ";
            // 
            // txtLogInPassword
            // 
            this.txtLogInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogInPassword.Location = new System.Drawing.Point(91, 80);
            this.txtLogInPassword.Multiline = true;
            this.txtLogInPassword.Name = "txtLogInPassword";
            this.txtLogInPassword.Size = new System.Drawing.Size(160, 24);
            this.txtLogInPassword.TabIndex = 2;
            // 
            // txtLogInEmail
            // 
            this.txtLogInEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogInEmail.Location = new System.Drawing.Point(91, 30);
            this.txtLogInEmail.Multiline = true;
            this.txtLogInEmail.Name = "txtLogInEmail";
            this.txtLogInEmail.Size = new System.Drawing.Size(160, 24);
            this.txtLogInEmail.TabIndex = 1;
            // 
            // lblLogInEmail
            // 
            this.lblLogInEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInEmail.Location = new System.Drawing.Point(10, 30);
            this.lblLogInEmail.Name = "lblLogInEmail";
            this.lblLogInEmail.Size = new System.Drawing.Size(50, 24);
            this.lblLogInEmail.TabIndex = 0;
            this.lblLogInEmail.Text = "Email : ";
            // 
            // SignUp
            // 
            this.SignUp.Controls.Add(this.cmbGrade);
            this.SignUp.Controls.Add(this.cmbGender);
            this.SignUp.Controls.Add(this.chkSignUpShowPassword);
            this.SignUp.Controls.Add(this.txtSchool);
            this.SignUp.Controls.Add(this.txtMobileNumber);
            this.SignUp.Controls.Add(this.txtSignUpPassword);
            this.SignUp.Controls.Add(this.txtSurname);
            this.SignUp.Controls.Add(this.txtSignUpEmail);
            this.SignUp.Controls.Add(this.txtName);
            this.SignUp.Controls.Add(this.btnSignUp);
            this.SignUp.Controls.Add(this.lblPassword);
            this.SignUp.Controls.Add(this.lblSchool);
            this.SignUp.Controls.Add(this.lblGender);
            this.SignUp.Controls.Add(this.lblGrade);
            this.SignUp.Controls.Add(this.lblMobileNumber);
            this.SignUp.Controls.Add(this.lblEmail);
            this.SignUp.Controls.Add(this.lblSurname);
            this.SignUp.Controls.Add(this.lblName);
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.Location = new System.Drawing.Point(440, 50);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(420, 400);
            this.SignUp.TabIndex = 1;
            this.SignUp.TabStop = false;
            this.SignUp.Text = "Sign UP";
            // 
            // cmbGrade
            // 
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbGrade.ItemHeight = 16;
            this.cmbGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbGrade.Location = new System.Drawing.Point(125, 230);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(160, 24);
            this.cmbGrade.TabIndex = 21;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbGender.ItemHeight = 16;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(125, 270);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(160, 24);
            this.cmbGender.TabIndex = 20;
            // 
            // chkSignUpShowPassword
            // 
            this.chkSignUpShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSignUpShowPassword.Location = new System.Drawing.Point(290, 150);
            this.chkSignUpShowPassword.Name = "chkSignUpShowPassword";
            this.chkSignUpShowPassword.Size = new System.Drawing.Size(126, 24);
            this.chkSignUpShowPassword.TabIndex = 19;
            this.chkSignUpShowPassword.Text = "Show Password";
            this.chkSignUpShowPassword.UseVisualStyleBackColor = true;
            this.chkSignUpShowPassword.CheckedChanged += new System.EventHandler(this.chkSignUpShowPassword_CheckedChanged);
            // 
            // txtSchool
            // 
            this.txtSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchool.Location = new System.Drawing.Point(125, 310);
            this.txtSchool.Multiline = true;
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(160, 24);
            this.txtSchool.TabIndex = 17;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNumber.Location = new System.Drawing.Point(125, 190);
            this.txtMobileNumber.Multiline = true;
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(160, 24);
            this.txtMobileNumber.TabIndex = 15;
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpPassword.Location = new System.Drawing.Point(125, 150);
            this.txtSignUpPassword.Multiline = true;
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.Size = new System.Drawing.Size(160, 24);
            this.txtSignUpPassword.TabIndex = 13;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(125, 70);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(160, 24);
            this.txtSurname.TabIndex = 12;
            // 
            // txtSignUpEmail
            // 
            this.txtSignUpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpEmail.Location = new System.Drawing.Point(125, 110);
            this.txtSignUpEmail.Multiline = true;
            this.txtSignUpEmail.Name = "txtSignUpEmail";
            this.txtSignUpEmail.Size = new System.Drawing.Size(160, 24);
            this.txtSignUpEmail.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(125, 30);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 24);
            this.txtName.TabIndex = 10;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(135, 350);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(118, 35);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(10, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 24);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password :";
            // 
            // lblSchool
            // 
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(10, 310);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(63, 24);
            this.lblSchool.TabIndex = 7;
            this.lblSchool.Text = "School : ";
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(10, 270);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(68, 24);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender : ";
            // 
            // lblGrade
            // 
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(10, 230);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(56, 24);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "Grade :";
            this.lblGrade.Click += new System.EventHandler(this.lblGrade_Click);
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileNumber.Location = new System.Drawing.Point(10, 190);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(115, 24);
            this.lblMobileNumber.TabIndex = 4;
            this.lblMobileNumber.Text = "Mobile Number : ";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(10, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 24);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email :";
            // 
            // lblSurname
            // 
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(10, 70);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 25);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname :";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(894, 491);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.LogIn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LogIn.ResumeLayout(false);
            this.LogIn.PerformLayout();
            this.SignUp.ResumeLayout(false);
            this.SignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LogIn;
        private System.Windows.Forms.Label lblLogInEmail;
        private System.Windows.Forms.TextBox txtLogInEmail;
        private System.Windows.Forms.Label lblLogInPassword;
        private System.Windows.Forms.TextBox txtLogInPassword;
        private System.Windows.Forms.GroupBox SignUp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtSignUpPassword;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtSignUpEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkSignUpShowPassword;
        private System.Windows.Forms.CheckBox chkLogInShowPassword;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbGrade;
    }
}

