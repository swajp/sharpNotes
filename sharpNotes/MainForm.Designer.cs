namespace sharpNotes
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonExit = new Button();
            buttonMinimize = new Button();
            buttonAddNote = new Button();
            panel2 = new Panel();
            labelWelcome = new Label();
            panel3 = new Panel();
            buttonRefresh = new Button();
            listViewNotes = new ListView();
            columnHeader1 = new ColumnHeader();
            panelNewNote = new Panel();
            buttonSaveNote = new Button();
            buttonDeleteNote = new Button();
            label3 = new Label();
            textBoxText = new TextBox();
            label2 = new Label();
            textBoxTitle = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelNewNote.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 40);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 16);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 18;
            label1.Text = "sharpNotes";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.sahrpNotes___logo22;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(14, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.Black;
            buttonExit.Location = new Point(770, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(23, 38);
            buttonExit.TabIndex = 14;
            buttonExit.TabStop = false;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.Transparent;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinimize.ForeColor = Color.Black;
            buttonMinimize.Location = new Point(742, 2);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(22, 38);
            buttonMinimize.TabIndex = 15;
            buttonMinimize.TabStop = false;
            buttonMinimize.Text = "─";
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonAddNote
            // 
            buttonAddNote.BackColor = Color.Transparent;
            buttonAddNote.BackgroundImage = Properties.Resources.new_note;
            buttonAddNote.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAddNote.FlatAppearance.BorderSize = 0;
            buttonAddNote.FlatStyle = FlatStyle.Flat;
            buttonAddNote.Location = new Point(570, 9);
            buttonAddNote.Name = "buttonAddNote";
            buttonAddNote.Size = new Size(28, 28);
            buttonAddNote.TabIndex = 16;
            buttonAddNote.TabStop = false;
            buttonAddNote.UseVisualStyleBackColor = false;
            buttonAddNote.Click += buttonAddNote_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(labelWelcome);
            panel2.Controls.Add(buttonAddNote);
            panel2.Location = new Point(195, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(607, 40);
            panel2.TabIndex = 17;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcome.Location = new Point(3, 16);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(107, 21);
            labelWelcome.TabIndex = 17;
            labelWelcome.Text = "welcomemsg";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(buttonRefresh);
            panel3.Controls.Add(listViewNotes);
            panel3.Location = new Point(12, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 422);
            panel3.TabIndex = 18;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.Transparent;
            buttonRefresh.BackgroundImage = Properties.Resources.material_symbols_refresh;
            buttonRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Location = new Point(145, 7);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(23, 23);
            buttonRefresh.TabIndex = 19;
            buttonRefresh.TabStop = false;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // listViewNotes
            // 
            listViewNotes.BorderStyle = BorderStyle.None;
            listViewNotes.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewNotes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listViewNotes.FullRowSelect = true;
            listViewNotes.GridLines = true;
            listViewNotes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewNotes.Location = new Point(3, 3);
            listViewNotes.MultiSelect = false;
            listViewNotes.Name = "listViewNotes";
            listViewNotes.RightToLeftLayout = true;
            listViewNotes.Size = new Size(171, 416);
            listViewNotes.TabIndex = 0;
            listViewNotes.TabStop = false;
            listViewNotes.UseCompatibleStateImageBehavior = false;
            listViewNotes.View = View.Details;
            listViewNotes.SelectedIndexChanged += listViewNotes_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Poznámky";
            columnHeader1.Width = 180;
            // 
            // panelNewNote
            // 
            panelNewNote.BackColor = Color.Transparent;
            panelNewNote.BackgroundImage = Properties.Resources.rounded_gray;
            panelNewNote.BackgroundImageLayout = ImageLayout.Stretch;
            panelNewNote.Controls.Add(buttonSaveNote);
            panelNewNote.Controls.Add(buttonDeleteNote);
            panelNewNote.Controls.Add(label3);
            panelNewNote.Controls.Add(textBoxText);
            panelNewNote.Controls.Add(label2);
            panelNewNote.Controls.Add(textBoxTitle);
            panelNewNote.Location = new Point(195, 92);
            panelNewNote.Name = "panelNewNote";
            panelNewNote.Size = new Size(607, 376);
            panelNewNote.TabIndex = 19;
            // 
            // buttonSaveNote
            // 
            buttonSaveNote.BackColor = Color.Transparent;
            buttonSaveNote.BackgroundImage = Properties.Resources.material_symbols_save;
            buttonSaveNote.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaveNote.FlatAppearance.BorderSize = 0;
            buttonSaveNote.FlatStyle = FlatStyle.Flat;
            buttonSaveNote.Location = new Point(575, 12);
            buttonSaveNote.Name = "buttonSaveNote";
            buttonSaveNote.Size = new Size(23, 23);
            buttonSaveNote.TabIndex = 18;
            buttonSaveNote.TabStop = false;
            buttonSaveNote.UseVisualStyleBackColor = false;
            buttonSaveNote.Click += buttonSaveNote_Click;
            // 
            // buttonDeleteNote
            // 
            buttonDeleteNote.BackColor = Color.Transparent;
            buttonDeleteNote.BackgroundImage = (Image)resources.GetObject("buttonDeleteNote.BackgroundImage");
            buttonDeleteNote.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDeleteNote.FlatAppearance.BorderSize = 0;
            buttonDeleteNote.FlatStyle = FlatStyle.Flat;
            buttonDeleteNote.Location = new Point(557, 12);
            buttonDeleteNote.Name = "buttonDeleteNote";
            buttonDeleteNote.Size = new Size(23, 23);
            buttonDeleteNote.TabIndex = 19;
            buttonDeleteNote.TabStop = false;
            buttonDeleteNote.UseVisualStyleBackColor = false;
            buttonDeleteNote.Click += buttonDeleteNote_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 85);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 21;
            label3.Text = "Text:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxText
            // 
            textBoxText.AcceptsTab = true;
            textBoxText.BorderStyle = BorderStyle.None;
            textBoxText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxText.Location = new Point(13, 107);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(585, 256);
            textBoxText.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 16);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 19;
            label2.Text = "Název:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTitle
            // 
            textBoxTitle.BorderStyle = BorderStyle.None;
            textBoxTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitle.Location = new Point(13, 38);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(585, 29);
            textBoxTitle.TabIndex = 18;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.rounded_main;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(814, 480);
            Controls.Add(panelNewNote);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonMinimize);
            Controls.Add(buttonExit);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panelNewNote.ResumeLayout(false);
            panelNewNote.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonExit;
        private Button buttonMinimize;
        private Button buttonAddNote;
        private Panel panel2;
        private Label labelWelcome;
        private Panel panel3;
        private Panel panelNewNote;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxTitle;
        private Label label3;
        private TextBox textBoxText;
        private Button buttonSaveNote;
        private Button buttonDeleteNote;
        private ListView listViewNotes;
        private ColumnHeader columnHeader1;
        private Button buttonRefresh;
    }
}