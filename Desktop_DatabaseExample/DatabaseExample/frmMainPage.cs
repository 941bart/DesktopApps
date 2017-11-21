using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseExample
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void btnDemo1_Click(object sender, EventArgs e)
        {
            //When clicked direct user to Demo1
            frmDemo1 Demo1Form = new frmDemo1();
            //Show Demo1Form
            Demo1Form.Show();
            //Hide frmMainPage
            this.Hide();
        }

        private void btnDemo2_Click(object sender, EventArgs e)
        {
            //When clicked direct user to Demo2
            frmDemo2 Demo2Form = new frmDemo2();
            //Show Demo2Form
            Demo2Form.Show();
            //Hide frmMainPage
            this.Hide();
        }

        private void btnDemo3_Click(object sender, EventArgs e)
        {
            //When clicked direct user to Demo3
            frmDemo3 Demo3Form = new frmDemo3();
            //Show Demo3Form
            Demo3Form.Show();
            //Hide the frmMainPage
            this.Hide();
        }

        private void btnDemo4_Click(object sender, EventArgs e)
        {
            //When clicked direct user to Demo3
            frmDemo4 Demo4Form = new frmDemo4();
            //Show Demo3Form
            Demo4Form.Show();
            //Hide the frmMainPage
            this.Hide();
        }
    }
}
