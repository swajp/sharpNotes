namespace sharpNotes
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            buttonLogin = new Button();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label2 = new Label();
            textBoxUsername = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonCloseApp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.BackgroundImageLayout = ImageLayout.None;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(21, 330);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(262, 39);
            buttonLogin.TabIndex = 22;
            buttonLogin.Text = "Přihlásit se";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 241);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 19;
            label3.Text = "Heslo:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(21, 268);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(262, 39);
            textBoxPassword.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 162);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 17;
            label2.Text = "Uživatelské jméno";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(21, 189);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(262, 39);
            textBoxUsername.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(82, 102);
            label1.Name = "label1";
            label1.Size = new Size(143, 37);
            label1.TabIndex = 15;
            label1.Text = "Přihlášení";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.sahrpNotes___logo22;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(126, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // buttonCloseApp
            // 
            buttonCloseApp.BackColor = Color.Transparent;
            buttonCloseApp.FlatAppearance.BorderSize = 0;
            buttonCloseApp.FlatStyle = FlatStyle.Flat;
            buttonCloseApp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCloseApp.Location = new Point(271, 17);
            buttonCloseApp.Name = "buttonCloseApp";
            buttonCloseApp.Size = new Size(36, 38);
            buttonCloseApp.TabIndex = 13;
            buttonCloseApp.Text = "X";
            buttonCloseApp.UseVisualStyleBackColor = false;
            buttonCloseApp.Click += buttonCloseApp_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.rounded_bg2;
            ClientSize = new Size(329, 411);
            Controls.Add(buttonLogin);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCloseApp);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label2;
        private TextBox textBoxUsername;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonCloseApp;
    }
}