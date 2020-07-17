using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studiosoftware
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            customizedesign();
        }
        private void customizedesign()
        {
            mediaSubMenuPanel.Visible = false;
            BookingsPanel.Visible = false;
        }
        private void hidesubmenu()
        {
            if (mediaSubMenuPanel.Visible == true)
                mediaSubMenuPanel.Visible = false;

            if (BookingsPanel.Visible == true)
                BookingsPanel.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            EmpMember emp1 = new EmpMember();
            emp1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void sideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

      

        private void button2_Click_1(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

       

        private void Staffmemberbtn_Click(object sender, EventArgs e)
        {
            showSubmenu(mediaSubMenuPanel);
        }

        private void bookingsBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(BookingsPanel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //code
            hidesubmenu();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
