namespace Netheret
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblEmail = new Label();
            LblPassword = new Label();
            BtnLogin = new Button();
            BtnSignUp = new Button();
            TxtEmail = new TextBox();
            TxtPassword = new TextBox();
            btnShowPassword = new Button();
            SuspendLayout();
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(104, 68);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 1;
            LblEmail.Text = "Email";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(104, 165);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(57, 15);
            LblPassword.TabIndex = 3;
            LblPassword.Text = "Password";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(133, 240);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(123, 32);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += button1_Click;
            // 
            // BtnSignUp
            // 
            BtnSignUp.Location = new Point(147, 278);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(96, 26);
            BtnSignUp.TabIndex = 5;
            BtnSignUp.Text = "Sign Up";
            BtnSignUp.UseVisualStyleBackColor = true;
            BtnSignUp.Click += button2_Click;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(104, 86);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(184, 23);
            TxtEmail.TabIndex = 6;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(104, 183);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(184, 23);
            TxtPassword.TabIndex = 7;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(294, 183);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(25, 23);
            btnShowPassword.TabIndex = 8;
            btnShowPassword.Text = "👁";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 365);
            Controls.Add(btnShowPassword);
            Controls.Add(TxtPassword);
            Controls.Add(TxtEmail);
            Controls.Add(BtnSignUp);
            Controls.Add(BtnLogin);
            Controls.Add(LblPassword);
            Controls.Add(LblEmail);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblEmail;
        private Label LblPassword;
        private Button BtnLogin;
        private Button BtnSignUp;
        private TextBox TxtEmail;
        private TextBox TxtPassword;
        private Button btnShowPassword;
    }
}
