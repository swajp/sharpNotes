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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Gray;
            this.BackColor = Color.Gray;
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != string.Empty && textBoxPassword.Text != string.Empty && textBoxPasswordAgain.Text != string.Empty)
            {
                if (textBoxPassword.Text == textBoxPasswordAgain.Text)
                {
                    SqlRepository.SignupUser(textBoxUsername.Text, textBoxPassword.Text);
                    if (SqlRepository.serverStatus != "Error")
                    {
                        MessageBox.Show("Úspěšně zaregistorován!");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Hesla se musí shodovat!");
                }
            }
            else
            {
                MessageBox.Show("Vyplňte všechna pole");
            }
        }
    }
}
