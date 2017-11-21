using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //An abstract-base Car class indended for other classes derieve from
    //Inherits ICarInterface <add more>
    abstract class Car
    {
        
        #region Car Class Fields 
        private string _make;
        private string _model;
        private string _color;
        private decimal _price;
        private decimal _mpg;
        private decimal _gasTankGallons;
        private int _numberOfWheels;
        private int _numberOfDoors;
        private Boolean _automaticTransmission;
        #endregion

        #region Car Class Constructor 
        //Constructor with 9 properties 
        public Car(string make, string model, decimal price, string color, int numberOfWheels, int numberOfDoors, Boolean automaticTransmission, decimal mpg, decimal gasTankGallons)
        {
            _make = make;
            _model = model;
            _price = price;
            _color = color;
            _numberOfWheels = numberOfWheels;
            _numberOfDoors = numberOfDoors;
            _automaticTransmission = automaticTransmission;
            _mpg = mpg;
            _gasTankGallons = gasTankGallons;
        }
        #endregion

        public Car()
        {
            _make = "";
            _model = "";
            _price = -1;
            _color = "";
            _numberOfWheels = -1;
            _numberOfDoors = -1;
            _automaticTransmission = false;
            _mpg = -1;
            _gasTankGallons = -1;
        }

        #region Car Class Properties 
        //Car Make Property 
        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                _make = value;
            }
        }

        //Car Model Property 
        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        //Car Price Property 
        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        //Car Color Property 
        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        //Car NumberOfWheels Property 
        public int NumberOfWheels
        {
            get
            {
                return _numberOfWheels;
            }

            set
            {
                _numberOfWheels = value;
            }
        }

        //Car NumberOfDoors Property 
        public int NumberOfDoors
        {
            get
            {
                return _numberOfDoors;
            }

            set
            {
                _numberOfDoors = value;
            }
        }
        //Car AutomaticTransmittion Property 
        public Boolean AutomaticTransmission
        {
            get
            {
                return _automaticTransmission;
            }
            set
            {
                _automaticTransmission = value;
            }
        }
        //Car Range Property
        public decimal MPG
        {
            get
            {
                return _mpg;
            }

            set
            {
                _mpg = value;
            }
        }
        //Car GasTankGallons Property
        public decimal GasTankGallons
        {
            get
            {
                return _gasTankGallons;
            }
            set
            {
                _gasTankGallons = value;
            }
        }
        #endregion

        #region Car Methods

        //To String Method showing class details instead of object name and namespace default // override vs virtual-override
        public override string ToString()
        {
            //return "Car make: {0}, Model: {1}, Price: {2}, Color: {3}, Number of wheels: {4}, Number of doors: {5}, Automatic Transmission: {6}, Range: {7}, Gas tank gallons hold: {8}" Make, Model, Price, Color, NumberOfWhells, NumberOfDoors, AutomaticTransmission, Range, GasTankGallons;

            return "Car make: " + Make + ", " + "Model:" + Model + ", " + "Price:" + Price + ", " + "Color:" + Color + " ," + "Number of wheels:" + NumberOfWheels + " ," + "Automatic Transmission:" + AutomaticTransmission + " ," + "MPG:" + MPG + " ," + "Gas tank gallons hold:" + GasTankGallons;
        }

        //Create Range a virtual method required by ICarInterface 
        public virtual decimal Range(decimal _mpg, decimal _gasTankGallons)
        {
            decimal Range = _mpg * _gasTankGallons;
            return Range;
        }

        #endregion
    }
}
