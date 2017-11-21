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
    public partial class frmDemo4 : Form
    {
        public frmDemo4()
        {
            InitializeComponent();
        }

        private void Demo4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDatabaseDataSetSQLQueries.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.carsDatabaseDataSetSQLQueries.Table);
        }

        private void btnFillByPriceASC_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.FillByPriceAscending(this.carsDatabaseDataSetSQLQueries.Table);
        }

        private void btnFillByPriceDESC_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.FillByPriceDescending(this.carsDatabaseDataSetSQLQueries.Table);
        }

        private void btnFillByAutomaticTransmissionTrue_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.FillByAutomaticTransmissionTrue(this.carsDatabaseDataSetSQLQueries.Table);
        }

        private void btnFillByColorLikeWh_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.FillByColorLikeWh(this.carsDatabaseDataSetSQLQueries.Table);
        }

        private void btnFillByHorsePowerDescending_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.FillByHorsePowerDescending(this.carsDatabaseDataSetSQLQueries.Table);
        }

        private void btnAverageCarPrice_Click(object sender, EventArgs e)
        {
            //Declare a veriable to hold the average price
            decimal averagePrice;

            //Get the average price 
            averagePrice = (decimal)this.tableTableAdapter.AveragePrice();

            //Display the average price
            MessageBox.Show("Average price of all the cars is: " + averagePrice.ToString("c"));
        }

        private void btnSearchMake_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.SearchMakeValue(this.carsDatabaseDataSetSQLQueries.Table, txtBoxSearch.Text);
        }

        private void btnShowAllItems_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.carsDatabaseDataSetSQLQueries.Table);
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
