﻿using System;
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
    public partial class frmDemo1 : Form
    {
        public frmDemo1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carsDatabaseDataSet);

        }

        private void Demo1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.carsDatabaseDataSet.Table);

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            //When clicked direct user to MainPage
            frmMainPage MainPageForm = new frmMainPage();
            //Show Demo1Form
            MainPageForm.Show();
            //Hide frmMainPage
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close application
            Application.Exit();
        }
    }
}
