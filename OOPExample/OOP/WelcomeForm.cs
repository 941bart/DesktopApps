using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class frmWelcomeForm : Form
    {
        public frmWelcomeForm()
        {
            InitializeComponent();
        }

        #region List Objects to hold Classes
        //List to hold SportsCar objects for add button 
        List<SportsCar> SportsCarList = new List<SportsCar>();

        //List to hold SportsCar objects for demo button 
        List<SportsCar> SportsCarListDemo = new List<SportsCar>();
        #endregion

        //The GetSportsCarData method accepts a SportsCar object as an argument.
        //and assigns the data entered by the user to the object's properties 
        #region GetSportsCarData SportsCar Method
        private void GetSportsCarData(SportsCar SportsCarObject)
        {
            //Temporary variables to hold conversion
            decimal price, mpg, gastankgallons, numberofcylinders, horsepower;
            int numberofwheels, numberofdoors;

            //Get the SportsCar make
            SportsCarObject.Make = textBoxSportCarMake.Text;

            //Get the SportsCar model
            SportsCarObject.Model = textBoxSportCarModel.Text;

            //Get the SportsCar price
            if (decimal.TryParse(textBoxSportCarPrice.Text, out price))
            {
                SportsCarObject.Price = price;
            }
            else
                //Display an error message
                MessageBox.Show("Invalid price");

            //Get the SportsCar color
            SportsCarObject.Color = textBoxSportCarColor.Text;

            //Get the SportsCar NumberOfWheels
            if (int.TryParse(textBoxSportCarNumberOfWheels.Text, out numberofwheels))
            {
                SportsCarObject.NumberOfWheels = numberofwheels;
            }
            else
                //Display an error message
                MessageBox.Show("Invalid NumberOfWheels");

            //Get the SportsCar NumberOfDoors
            if (int.TryParse(textBoxSportCarNumberOfDoors.Text, out numberofdoors))
            {
                SportsCarObject.NumberOfDoors = numberofdoors;
            }
            else
                //Display an error message
                MessageBox.Show("Invalid NumberOfDoors");

            //Get the SportsCar Automatic transmission bool
            if (checkBoxSportCarAutomaticTransmission.Checked == true)
            {
                SportsCarObject.AutomaticTransmission = true;
            }
            else
            {
                SportsCarObject.AutomaticTransmission = false;
            }
                
            //Get the SportsCar Mpg
            if (decimal.TryParse(textBoxSportCarMpg.Text, out mpg))
            {
                SportsCarObject.MPG = mpg;
            }
            else
                //Display an error message
                MessageBox.Show("Invalid MPG");

            //Get the SportsCar GasTankGallons
            if (decimal.TryParse(textBoxSportCarGasTankGallons.Text, out gastankgallons))
            {
                SportsCarObject.GasTankGallons = gastankgallons;
            }
            else
                //Display an error message
                MessageBox.Show("Invalid GasTankGallons");

            //Derived class fields
          
            //Get the SportsCar HorsePower
            if (decimal.TryParse(textBoxSportCarHorsePower.Text, out horsepower))
            {
                SportsCarObject.HorsePower = horsepower;
            }
            else
                //Display an error message
                MessageBox.Show("Invalid NumberOfCylinders");

            //Get the SportsCar NumberofCylinders
            if (decimal.TryParse(textBoxSportCarNumberOfCylinders.Text, out numberofcylinders))
            {
                SportsCarObject.NumberOfCylinders = numberofcylinders;
            }
            else
                //Display an error message
                MessageBox.Show("Invalid NumberOfCylinders");

        }
        #endregion

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            //Create a SportsCar object
            //how to create object with :base fields for horsepower and numberofcylinders <<<<
            SportsCar mySportsCar = new SportsCar();

            //Get the SportsCar data 
            GetSportsCarData(mySportsCar);

            //Add the SportsCar to the list 
            SportsCarList.Add(mySportsCar);

            //Add the entry to the list box 
            listBoxSportsCar.Items.Add("Make: " + mySportsCar.Make + " " + "Model: " + mySportsCar.Model + " " + "Color: " + mySportsCar.Color + " " + "Number of wheels: " + mySportsCar.NumberOfWheels + " " + "Number of doors: " + mySportsCar.NumberOfDoors + " " + "Automatic transmission: " + mySportsCar.AutomaticTransmission + " " + "MPG: " + mySportsCar.MPG + " " +  "Gas tank gallons: " + mySportsCar.GasTankGallons + " " + "Horse power: " + mySportsCar.HorsePower + " " + "Decimal: " + mySportsCar.NumberOfCylinders);

            //Clear text box controls 
            textBoxSportCarMake.Clear();
            textBoxSportCarModel.Clear();
            textBoxSportCarColor.Clear();
            textBoxSportCarPrice.Clear();
            textBoxSportCarMpg.Clear();
            textBoxSportCarGasTankGallons.Clear();
            textBoxSportCarNumberOfWheels.Clear();
            textBoxSportCarNumberOfDoors.Clear();
            //Uncheck checkbox
            checkBoxSportCarAutomaticTransmission.Checked = false;
            //Clear derived class text box controls 
            textBoxSportCarHorsePower.Clear();
            textBoxSportCarNumberOfCylinders.Clear();
        }

        private void listBoxSportsCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the index of selected item 
            int index = listBoxSportsCar.SelectedIndex;

            //Display selected SportsCar price in a messagebox
            MessageBox.Show(SportsCarList[index].Price.ToString("c"));
        }

        private void buttonDemo_Click(object sender, EventArgs e)
        {
            //Create sample examples of SportsCar
            SportsCar mySportsCarDemo1 = new SportsCar("Audi", "R8", 58000, "White", 4, 2, true, 12, 24, 500, 10);
            SportsCar mySportsCarDemo2 = new SportsCar("Ford", "GT", 72000, "Red", 4, 2, false, 13, 25, 480, 8);
            SportsCar mySportsCarDemo3 = new SportsCar("Nissan", "GTR", 66000, "Orange", 4, 2, true, 16, 24, 450, 6);
            SportsCar mySportsCarDemo4 = new SportsCar("Audi", "S4", 45000, "Black", 4, 4, true, 18, 26, 440, 6);

            //Add the SportsCarDemo to the demo list 
            SportsCarListDemo.Add(mySportsCarDemo1);
            SportsCarListDemo.Add(mySportsCarDemo2);
            SportsCarListDemo.Add(mySportsCarDemo3);
            SportsCarListDemo.Add(mySportsCarDemo4);

            //Add the entry to the list box 
            listBoxDemoSportsCar.Items.Add("Make: " + mySportsCarDemo1.Make + " " + "Model: " + mySportsCarDemo1.Model + " " + "Color: " + mySportsCarDemo1.Color + " " + "Number of wheels: " + mySportsCarDemo1.NumberOfWheels + " " + "Number of doors: " + mySportsCarDemo1.NumberOfDoors + " " + "Automatic transmission: " + mySportsCarDemo1.AutomaticTransmission + " " + "MPG: " + mySportsCarDemo1.MPG + " " + "Gas tank gallons: " + mySportsCarDemo1.GasTankGallons + " " + "Horse power: " + mySportsCarDemo1.HorsePower + " " + "Decimal: " + mySportsCarDemo1.NumberOfCylinders);
            listBoxDemoSportsCar.Items.Add("Make: " + mySportsCarDemo2.Make + " " + "Model: " + mySportsCarDemo2.Model + " " + "Color: " + mySportsCarDemo2.Color + " " + "Number of wheels: " + mySportsCarDemo2.NumberOfWheels + " " + "Number of doors: " + mySportsCarDemo2.NumberOfDoors + " " + "Automatic transmission: " + mySportsCarDemo2.AutomaticTransmission + " " + "MPG: " + mySportsCarDemo2.MPG + " " + "Gas tank gallons: " + mySportsCarDemo2.GasTankGallons + " " + "Horse power: " + mySportsCarDemo2.HorsePower + " " + "Decimal: " + mySportsCarDemo2.NumberOfCylinders);
            listBoxDemoSportsCar.Items.Add("Make: " + mySportsCarDemo3.Make + " " + "Model: " + mySportsCarDemo3.Model + " " + "Color: " + mySportsCarDemo3.Color + " " + "Number of wheels: " + mySportsCarDemo3.NumberOfWheels + " " + "Number of doors: " + mySportsCarDemo3.NumberOfDoors + " " + "Automatic transmission: " + mySportsCarDemo3.AutomaticTransmission + " " + "MPG: " + mySportsCarDemo3.MPG + " " + "Gas tank gallons: " + mySportsCarDemo3.GasTankGallons + " " + "Horse power: " + mySportsCarDemo3.HorsePower + " " + "Decimal: " + mySportsCarDemo3.NumberOfCylinders);
            listBoxDemoSportsCar.Items.Add("Make: " + mySportsCarDemo4.Make + " " + "Model: " + mySportsCarDemo4.Model + " " + "Color: " + mySportsCarDemo4.Color + " " + "Number of wheels: " + mySportsCarDemo4.NumberOfWheels + " " + "Number of doors: " + mySportsCarDemo4.NumberOfDoors + " " + "Automatic transmission: " + mySportsCarDemo4.AutomaticTransmission + " " + "MPG: " + mySportsCarDemo4.MPG + " " + "Gas tank gallons: " + mySportsCarDemo4.GasTankGallons + " " + "Horse power: " + mySportsCarDemo4.HorsePower + " " + "Decimal: " + mySportsCarDemo4.NumberOfCylinders);
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            //Clear List Box
            listBoxSportsCar.Items.Clear();
            listBoxDemoSportsCar.Items.Clear();
        }

        private void listBoxDemoSportsCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the index of selected item 
            int index = listBoxDemoSportsCar.SelectedIndex;

            //Display selected SportsCar price in a messagebox
            MessageBox.Show(SportsCarListDemo[index].Price.ToString("c"));
        }
    }
}
