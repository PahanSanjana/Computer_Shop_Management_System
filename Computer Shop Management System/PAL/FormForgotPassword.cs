using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.PAL
{
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter User Name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string pass = Computer.Computer.ForgotPassword(txtUsername.Text.Trim(), txtEmail.Text.Trim());
                if (pass != string.Empty)
                {
                    MessageBox.Show($"Your Password is: {pass}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("User Name or Email is Incorrect.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
