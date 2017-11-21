using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
        //Sports car class inhereting from Car Class 
        class SportsCar : Car
        {
        #region SportsCar Class Fields 
            private decimal _horsePower;
            private decimal _numberOfCylinders;
        #endregion

        #region SportsCar Constructor 
        //Constructor with 9 base properties + 2 specialized properties
        public SportsCar(string make, string model, decimal price, string color, int numberofwheels, int numberofdoors, bool automatictransmission, decimal mpg, decimal gastankgallons, decimal horsePower, decimal numberOfCylinders)
            : base(make, model, price, color, numberofwheels, numberofdoors, automatictransmission, -1, -1)
        {
            _horsePower = horsePower;
            _numberOfCylinders = numberOfCylinders;
        }

        public SportsCar(decimal horsePower, decimal numberOfCylinders)
            : base()
        {
            _horsePower = horsePower;
            _numberOfCylinders = numberOfCylinders;
        }

        public SportsCar()
            : base()
        {
            _horsePower = -1;
            _numberOfCylinders = -1;
        }

        #endregion

        #region SportsCar Properties 

        //SportsCar HorsePower Property
        public decimal HorsePower
            {
                get
                {
                    return _horsePower;
                }

                set
                {
                    _horsePower = value;
                }
            }

            //SportsCar NumberOfCylinders Property
            public decimal NumberOfCylinders
            {
                get
                {
                    return _numberOfCylinders;
                }

                set
                {
                    _numberOfCylinders = value;
                }
            }
            #endregion

        #region SportsCar Methods

            //To String Method showing class details instead of object name and namespace default 
            public override string ToString()
            {
                return "Car make: " + Make + ", " + "Model:" + Model + ", " + "Price:" + Price + ", " + "Color:" + Color + " ," + "Automatic Transmission:" + AutomaticTransmission + " ," + "Gas tank gallons hold:" + GasTankGallons + " ," + "Horse Power:" + HorsePower + "Number of cylinders:" + NumberOfCylinders;
            }

            //Create Range method required by ICarInterface
            //Method overrides original virtual method found in car class  
            public override decimal Range(decimal _mpg, decimal _gasTankGallons)
            {
                decimal Range = _mpg * _gasTankGallons;
                return Range;
            }
            #endregion
        }
    }

