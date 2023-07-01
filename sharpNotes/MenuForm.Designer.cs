namespace sharpNotes
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            buttonLogin = new Button();
            buttonSignup = new Button();
            buttonCloseApp = new Button();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Image = Properties.Resources.mdi_user_exists;
            buttonLogin.Location = new Point(42, 43);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(154, 156);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Přihlásit se";
            buttonLogin.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonSignup
            // 
            buttonSignup.BackColor = Color.Transparent;
            buttonSignup.FlatAppearance.BorderSize = 0;
            buttonSignup.FlatStyle = FlatStyle.Flat;
            buttonSignup.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignup.Image = (Image)resources.GetObject("buttonSignup.Image");
            buttonSignup.Location = new Point(258, 43);
            buttonSignup.Name = "buttonSignup";
            buttonSignup.Size = new Size(182, 156);
            buttonSignup.TabIndex = 1;
            buttonSignup.Text = "Zaregistrovat se";
            buttonSignup.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonSignup.UseVisualStyleBackColor = false;
            buttonSignup.Click += buttonSignup_Click;
            // 
            // buttonCloseApp
            // 
            buttonCloseApp.BackColor = Color.Transparent;
            buttonCloseApp.FlatAppearance.BorderSize = 0;
            buttonCloseApp.FlatStyle = FlatStyle.Flat;
            buttonCloseApp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCloseApp.Location = new Point(436, 12);
            buttonCloseApp.Name = "buttonCloseApp";
            buttonCloseApp.Size = new Size(36, 38);
            buttonCloseApp.TabIndex = 2;
            buttonCloseApp.Text = "X";
            buttonCloseApp.UseVisualStyleBackColor = false;
            buttonCloseApp.Click += buttonCloseApp_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.rounded_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 253);
            Controls.Add(buttonCloseApp);
            Controls.Add(buttonSignup);
            Controls.Add(buttonLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogin;
        private Button buttonSignup;
        private Button buttonCloseApp;
    }
}