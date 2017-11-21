using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace XMLexample
{
    public class SerializableData
    {

        #region Methods Void

        //Save method
        public void Save(string fileName)
        {
            //Create a temp file
            string tempFile = fileName + ".tmp";
            FileInfo tempFileInfo = new FileInfo(tempFile);
            //If file exists - delete
            if (tempFileInfo.Exists)
                tempFileInfo.Delete();
            //Create FileStream type, create mode 
            FileStream stream = new FileStream(tempFile, FileMode.Create);
            //Pass stream FileStream to Save method 
            Save(stream);
            //Close stream after finished 
            stream.Close();
            tempFileInfo.CopyTo(fileName, true);
            tempFileInfo.Delete();
        }

        public void Save(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(this.GetType());
            serializer.Serialize(stream, this);
        }
        #endregion


        #region Methods Static 

        public static object Load(string fileName, Type newType)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            if (!fileInfo.Exists)
                return System.Activator.CreateInstance(newType);
            FileStream stream = new FileStream(fileName, FileMode.Open);
            object newObject = Load(stream, newType);
            stream.Close();
            return newObject; 
        }

        public static object Load(Stream stream, Type newType)
        {
            XmlSerializer serializer = new XmlSerializer(newType);
            object newObject = serializer.Deserialize(stream);
            return newObject;
        }
        #endregion

        public class XMLCarClass : SerializableData
        {
            private string Make, Model, Color, Price, NumberOfDoors;
          
            #region Properties 

            public string CarMake
            {
                get { return Make; }
                set { Make = value; }
            }

            public string CarModel
            {
                get { return Model; }
                set { Model = value; }
            }

            public string CarPrice
            {
                get { return Price; }
                set { Price = value; }
            }

            public string CarColor
            {
                get { return Color; }
                set { Color = value; }
            }

            public string CarNumberOfDoors
            {
                get { return NumberOfDoors; }
                set { NumberOfDoors = value; }
            }

            }

            #endregion

        }
    }

