using System;
using System.Windows.Forms;
//added
using System.IO;
using System.Text;
using System.Security.Cryptography;

// Credit goes to Stackoverflow where I found an example and modified it to my needs 

namespace HashingApplication
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            //Open file dialog for user to select a file 
            OpenFileDialog ofd = new OpenFileDialog();
            //limit user to text files 
            ofd.Filter = "txt files (*.txt)|*.txt";

            //When user presses ok do this
           if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Assign string fileInfo from OpenFileDialog.Filename property
                string fileInfo = ofd.FileName.ToString();
                //Assign label text property lblFilePath from fileInfo to show selected file 
                lblFilePath.Text = fileInfo;

                //Get file selected and run MD5 hash check
                //Create FileStream named file and pass fileInfo, open fileInfo
                FileStream file = new FileStream(fileInfo, FileMode.Open);
                //Create an instance of MD5CryptoServiceProvider
                MD5 md5 = new MD5CryptoServiceProvider();
                //Create byte array retVal, pass compute hash value for file 
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                //Create StringBuilder sb and loop through hash length
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }

                //Assign sb to lblHash
                lblHash.Text = sb.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();
        }
    }
}
