namespace sharpNotes
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            buttonCloseApp = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label4 = new Label();
            textBoxPasswordAgain = new TextBox();
            buttonSignup = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCloseApp
            // 
            buttonCloseApp.BackColor = Color.Transparent;
            buttonCloseApp.FlatAppearance.BorderSize = 0;
            buttonCloseApp.FlatStyle = FlatStyle.Flat;
            buttonCloseApp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCloseApp.Location = new Point(281, 12);
            buttonCloseApp.Name = "buttonCloseApp";
            buttonCloseApp.Size = new Size(36, 38);
            buttonCloseApp.TabIndex = 3;
            buttonCloseApp.Text = "X";
            buttonCloseApp.UseVisualStyleBackColor = false;
            buttonCloseApp.Click += buttonCloseApp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.sahrpNotes___logo22;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(128, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(84, 97);
            label1.Name = "label1";
            label1.Size = new Size(151, 37);
            label1.TabIndex = 5;
            label1.Text = "Registrace";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(31, 184);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(262, 39);
            textBoxUsername.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 157);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 7;
            label2.Text = "Uživatelské jméno";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 236);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 9;
            label3.Text = "Heslo:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(31, 263);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(262, 39);
            textBoxPassword.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 314);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 11;
            label4.Text = "Heslo znovu:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPasswordAgain
            // 
            textBoxPasswordAgain.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordAgain.Location = new Point(31, 341);
            textBoxPasswordAgain.Name = "textBoxPasswordAgain";
            textBoxPasswordAgain.PasswordChar = '●';
            textBoxPasswordAgain.Size = new Size(262, 39);
            textBoxPasswordAgain.TabIndex = 10;
            // 
            // buttonSignup
            // 
            buttonSignup.BackColor = Color.Transparent;
            buttonSignup.BackgroundImageLayout = ImageLayout.None;
            buttonSignup.FlatStyle = FlatStyle.Flat;
            buttonSignup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignup.Location = new Point(31, 404);
            buttonSignup.Name = "buttonSignup";
            buttonSignup.Size = new Size(262, 39);
            buttonSignup.TabIndex = 12;
            buttonSignup.Text = "Zaregistrovat se";
            buttonSignup.UseVisualStyleBackColor = false;
            buttonSignup.Click += buttonSignup_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.rounded_bg2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(329, 465);
            Controls.Add(buttonSignup);
            Controls.Add(label4);
            Controls.Add(textBoxPasswordAgain);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCloseApp);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCloseApp;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBoxUsername;
        private Label label2;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label4;
        private TextBox textBoxPasswordAgain;
        private Button buttonSignup;
    }
}