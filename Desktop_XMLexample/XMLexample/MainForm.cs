using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//added otherwise getting type or namespace could not be found for XMLCarClass 
using static XMLexample.SerializableData;

namespace XMLexample
{
    //Code credit goes to Stackoverflow, I found a sample code and modified it to my needs 

    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        #region Methods 

        //not sure how to assign decimal and int to label, change class properties to string for now
        public void populateFieldsFromTextboxes(XMLCarClass Car)
        {
            Car.CarMake = txtBoxCarMake.Text;
            Car.CarModel = txtBoxCarModel.Text;
            Car.CarPrice = txtBoxCarPrice.Text;
            Car.CarColor = txtBoxCarColor.Text;
            Car.CarNumberOfDoors = txtBoxCarNumberOfDoors.Text;
        }

        public void populateFromFileToLabels(XMLCarClass Car)
        {
            lblCarMake.Text = Car.CarMake;
            lblCarModel.Text = Car.CarModel;
            lblCarPrice.Text = Car.CarPrice;
            lblCarColor.Text = Car.CarColor;
            lblCarNumberOfDoors.Text = Car.CarNumberOfDoors;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName;
            XMLCarClass Car = new XMLCarClass();
            populateFieldsFromTextboxes(Car);
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Application.StartupPath + @"\CarFiles\";
            save.Filter = "XML files (*.xml) |*.xml";
            save.RestoreDirectory = true; 
            if (save.ShowDialog() == DialogResult.OK)
                {
                fileName = save.FileName;
                Car.Save(fileName);
                MessageBox.Show("The address was saved to " + fileName);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Application.StartupPath + @"\CarFiles\";
            openFile.Filter = "XML files (*.xml) | *.xml";
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XMLCarClass NewCar = (XMLCarClass)SerializableData.Load(openFile.FileName, typeof(XMLCarClass));

                populateFromFileToLabels(NewCar);
            }
        }
    }
}
