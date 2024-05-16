namespace PassItDrivingSchool
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            lblShowPassword = new Label();
            chkPassword = new CheckBox();
            lblMessage = new Label();
            txtConformPassword = new TextBox();
            lblConformPassword = new Label();
            btnSignUp = new Button();
            lblSignUp = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(296, 341);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(353, 34);
            txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(70, 343);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(106, 28);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Passsword";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F);
            txtUserName.Location = new Point(296, 287);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(353, 34);
            txtUserName.TabIndex = 5;
            txtUserName.KeyPress += txtUserName_KeyPress;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUserName.Location = new Point(70, 291);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(113, 28);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "User Name";
            // 
            // lblShowPassword
            // 
            lblShowPassword.AutoSize = true;
            lblShowPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblShowPassword.Location = new Point(296, 448);
            lblShowPassword.Margin = new Padding(4, 0, 4, 0);
            lblShowPassword.Name = "lblShowPassword";
            lblShowPassword.Size = new Size(162, 28);
            lblShowPassword.TabIndex = 19;
            lblShowPassword.Text = "Show Password?";
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Font = new Font("Segoe UI", 12F);
            chkPassword.Location = new Point(278, 455);
            chkPassword.Margin = new Padding(4);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(18, 17);
            chkPassword.TabIndex = 18;
            chkPassword.UseVisualStyleBackColor = true;
            chkPassword.CheckedChanged += chkPassword_CheckedChanged;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F);
            lblMessage.Location = new Point(296, 504);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 28);
            lblMessage.TabIndex = 17;
            // 
            // txtConformPassword
            // 
            txtConformPassword.Font = new Font("Segoe UI", 12F);
            txtConformPassword.Location = new Point(296, 394);
            txtConformPassword.Margin = new Padding(4);
            txtConformPassword.Name = "txtConformPassword";
            txtConformPassword.Size = new Size(353, 34);
            txtConformPassword.TabIndex = 14;
            // 
            // lblConformPassword
            // 
            lblConformPassword.AutoSize = true;
            lblConformPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblConformPassword.Location = new Point(70, 396);
            lblConformPassword.Margin = new Padding(4, 0, 4, 0);
            lblConformPassword.Name = "lblConformPassword";
            lblConformPassword.Size = new Size(183, 28);
            lblConformPassword.TabIndex = 16;
            lblConformPassword.Text = "Conform Password";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DarkGreen;
            btnSignUp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(416, 540);
            btnSignUp.Margin = new Padding(4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(123, 48);
            btnSignUp.TabIndex = 15;
            btnSignUp.Text = "Add";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblSignUp.Location = new Point(269, 216);
            lblSignUp.Margin = new Padding(4, 0, 4, 0);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(237, 54);
            lblSignUp.TabIndex = 20;
            lblSignUp.Text = "Add Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(260, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Registration_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(701, 599);
            Controls.Add(pictureBox1);
            Controls.Add(lblSignUp);
            Controls.Add(lblShowPassword);
            Controls.Add(chkPassword);
            Controls.Add(lblMessage);
            Controls.Add(txtConformPassword);
            Controls.Add(lblConformPassword);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Name = "Registration_Form";
            Text = "Registration_Form1";
            Load += Registration_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUserName;
        private Label lblUserName;
        private Label lblShowPassword;
        private CheckBox chkPassword;
        private Label lblMessage;
        private TextBox txtConformPassword;
        private Label lblConformPassword;
        private Button btnSignUp;
        private Label lblSignUp;
        private PictureBox pictureBox1;
    }
}