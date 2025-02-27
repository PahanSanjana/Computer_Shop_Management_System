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
    public partial class FormMain : Form
    {

        public string name = "{?}";

        public FormMain()
        {
            InitializeComponent();
        }


        private void MovePanel(Control btn)
        {
            pnlMove.Top = btn.Top;
            pnlMove.Height = btn.Height;
        }
        private void FromMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = name;
            timerDateAndTime.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Want to Log out?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                MovePanel(btnClose);
                timerDateAndTime.Stop();
                Close();
            }
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            MovePanel(btnDashbord);
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
            userControlDashbord1.Visible = true;
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            MovePanel(btnBrand);
            userControlDashbord1.Visible = false;
            userControlCategory1.Visible = false;
            userControlBrand1.EmptyBox();
            userControlBrand1.Visible = true;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            MovePanel(btnCategory);
            userControlDashbord1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.EmptyBox();
            userControlCategory1.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MovePanel(btnProduct);
            userControlDashbord1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MovePanel(btnOrders);
            userControlDashbord1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MovePanel(btnReport);
            userControlDashbord1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            MovePanel(btnUsers);
            userControlDashbord1.Visible = false;
            userControlBrand1.Visible = false;
            userControlCategory1.Visible = false;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblTimeAndDate.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }
    }
}
