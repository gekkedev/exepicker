using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ExePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("config.csv"))
            {
                List<string> titleList = new List<string>();
                List<string> descriptionList = new List<string>();
                List<string> exeList = new List<string>();
                while (!reader.EndOfStream)
                {
                    //get and parse a line into an array
                    string line = reader.ReadLine();
                    string[] values = line.Split(';');

                    //save the values
                    titleList.Add(values[0]);
                    descriptionList.Add(values[1]);
                    exeList.Add(values[2]);
                }
                //display the values
                gameListBox.DataSource = titleList;
            }
        }
    }
}
