using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharpNotes
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            Loading loading = new Loading();

            var loadingStatus = loading.ShowDialog();
            if (loadingStatus == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            var result = login.ShowDialog();
            if (result == DialogResult.Cancel) { this.Show(); }
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm signup = new SignupForm();
            var result = signup.ShowDialog();
            if (result == DialogResult.Cancel || result == DialogResult.OK) { this.Show(); }
        }
    }
}
