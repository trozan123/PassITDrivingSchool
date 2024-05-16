namespace PassItDrivingSchool
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            lchkBox = new CheckBox();
            llblShowPassword = new Label();
            llblMessage = new Label();
            btnLogIn = new Button();
            lblLogIn = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lchkBox
            // 
            lchkBox.AutoSize = true;
            lchkBox.Font = new Font("Segoe UI", 12F);
            lchkBox.Location = new Point(207, 421);
            lchkBox.Margin = new Padding(3, 4, 3, 4);
            lchkBox.Name = "lchkBox";
            lchkBox.Size = new Size(18, 17);
            lchkBox.TabIndex = 21;
            lchkBox.UseVisualStyleBackColor = true;
            lchkBox.CheckedChanged += lchkBox_CheckedChanged_1;
            // 
            // llblShowPassword
            // 
            llblShowPassword.AutoSize = true;
            llblShowPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            llblShowPassword.Location = new Point(231, 416);
            llblShowPassword.Name = "llblShowPassword";
            llblShowPassword.Size = new Size(162, 28);
            llblShowPassword.TabIndex = 20;
            llblShowPassword.Text = "Show Password?";
            // 
            // llblMessage
            // 
            llblMessage.AutoSize = true;
            llblMessage.Font = new Font("Segoe UI", 12F);
            llblMessage.Location = new Point(173, 464);
            llblMessage.Name = "llblMessage";
            llblMessage.Size = new Size(0, 28);
            llblMessage.TabIndex = 19;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DarkGreen;
            btnLogIn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLogIn.ForeColor = SystemColors.Control;
            btnLogIn.Location = new Point(238, 507);
            btnLogIn.Margin = new Padding(3, 4, 3, 4);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(89, 58);
            btnLogIn.TabIndex = 17;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            lblLogIn.Location = new Point(234, 216);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(155, 60);
            lblLogIn.TabIndex = 16;
            lblLogIn.Text = "Log In";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(173, 356);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 34);
            txtPassword.TabIndex = 15;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(54, 359);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 28);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F);
            txtUserName.Location = new Point(173, 300);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(278, 34);
            txtUserName.TabIndex = 13;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUserName.Location = new Point(54, 303);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(113, 28);
            lblUserName.TabIndex = 12;
            lblUserName.Text = "User Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(198, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 201);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1080, 585);
            Controls.Add(pictureBox2);
            Controls.Add(lchkBox);
            Controls.Add(llblShowPassword);
            Controls.Add(llblMessage);
            Controls.Add(btnLogIn);
            Controls.Add(lblLogIn);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Name = "Login_Form";
            Text = "Login_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox lchkBox;
        private Label llblShowPassword;
        private Label llblMessage;
        private Button btnLogIn;
        private Label lblLogIn;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUserName;
        private Label lblUserName;
        private PictureBox pictureBox2;
    }
}