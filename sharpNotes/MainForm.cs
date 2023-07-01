using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharpNotes
{
    public partial class MainForm : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private List<Note> notes;
        private int uId;
        public MainForm(User user)
        {
            InitializeComponent();
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;

            uId = user.Id;
            LoadNotes();
            labelWelcome.Text = "Vítej, " + user.Username + "!";
            panelNewNote.Visible = false;
        }
        private void LoadNotes()
        {
            listViewNotes.Items.Clear();
            notes = SqlRepository.GetNotes(uId);

            foreach (var note in notes)
            {
                ListViewItem item = new ListViewItem(new string[] { note.Title, note.Text, });
                listViewNotes.Items.Add(item);
            }
            listViewNotes.Refresh();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool isCreatingNewNote = false;
        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            panelNewNote.Visible = true;
            textBoxTitle.Text = string.Empty;
            textBoxText.Text = string.Empty;
            isCreatingNewNote = true;
        }

        private void buttonSaveNote_Click(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count > 0 && isCreatingNewNote == false)
            {
                var note = notes[listViewNotes.SelectedIndices[0]];
                SqlRepository.EditNote(Convert.ToInt32(note.NoteId), textBoxTitle.Text, textBoxText.Text);
                LoadNotes();
            }
            else if (isCreatingNewNote == true)
            {
                SqlRepository.AddNote(textBoxTitle.Text, textBoxText.Text, Convert.ToInt32(uId));
                LoadNotes();
                isCreatingNewNote = false;
            }
            else
            {
                isCreatingNewNote = false;
            }
        }

        private void buttonDeleteNote_Click(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count > 0)
            {
                var note = notes[listViewNotes.SelectedIndices[0]];
                SqlRepository.DeleteNote(Convert.ToInt32(note.NoteId));
                listViewNotes.SelectedItems[0].Remove();
                LoadNotes();
                panelNewNote.Visible = false;
            }
        }

        private void listViewNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count > 0)
            {
                var note = notes[listViewNotes.SelectedIndices[0]];
                var title = note.Title;
                var text = note.Text;

                panelNewNote.Visible = true;
                textBoxTitle.Text = title;
                textBoxText.Text = text;
            }
            else
            {
                panelNewNote.Visible = false;
                isCreatingNewNote = false;
            }
            isCreatingNewNote = false;
        }
    }
}
