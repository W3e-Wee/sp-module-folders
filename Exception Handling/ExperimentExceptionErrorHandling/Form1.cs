using ExperimentExceptionErrorHandling.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimentExceptionErrorHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTestDivideByZero_Click(object sender, EventArgs e)
        {
            Calculator calculatorManager = new Calculator();
            var result = calculatorManager.Divide(5, 0);

        }

        private void buttonIndexOutOfBound_Click(object sender, EventArgs e)
        {
            int index = 0;
            string[] data = { "data 1", "data 2", "data 3" };
            while (index < 10)
            {
                this.textResult.Text += data[index] + "\n";
                index = index + 1;
            }//End of while
        }//End of buttonIndexOutOfBound

        private void buttonReadFromMissingFile_Click(object sender, EventArgs e)
        {
            TextReader tr;
            string line = null;
            //Apply the necessary code to retrieve data from a text file.
            //Build the correct file path to point the program to the file at correct location.
            string filepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ghostfile.txt";
            //Create a TextReader type object, tr and use it on the data.txt file
            tr = new StreamReader(filepath);
            //Begin a looping technique to get the tr object read data in the text file
            //"line-by-line" until the end-of-line.
            //Read the first line and use the line variable store the first line data
            line = tr.ReadLine();
            do
            {
                //Insert the line of data which was read from the file into the textbox control.
                this.textResult.Text += line + "\r\n";
                line = tr.ReadLine(); //Read the next line
            } while (line != null);
            //Close the reader, tr and release any system rescourses.
            tr.Close();
        }//End of buttonReadFromMissingFile_Click
    }//End of Form1 class
}//End of namespace
