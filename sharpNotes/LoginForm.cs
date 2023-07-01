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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != string.Empty && textBoxPassword.Text != string.Empty && textBoxPassword.Text != string.Empty)
            {
                var user = SqlRepository.GetUser(textBoxUsername.Text);
                if (user != null)
                {
                    if (user.VerifyPassword(textBoxPassword.Text))
                    {
                        DialogResult = DialogResult.OK;
                        MainForm main = new MainForm(user);
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Špatně zadané heslo!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vyplňte všechna pole");
            }
        }
    }
}
