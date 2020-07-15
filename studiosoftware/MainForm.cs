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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void staffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewmembers vm = new viewmembers();
            vm.Show();
        }

        private void addMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpMember emp = new EmpMember();
            emp.Show();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
