using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ExePicker
{
    public partial class Form1 : Form
    {
        List<string> titleList = new List<string>();
        List<string> descriptionList = new List<string>();
        List<string> exeList = new List<string>();
        string exeLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("config.csv"))
            {
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

        private void gameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameInfoGroupBox.Text = (string) ((ListBox) sender).SelectedValue;
            descriptionLabel.Text = descriptionList[((ListBox) sender).SelectedIndex];
            exeLocation = exeList[((ListBox)sender).SelectedIndex];
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(exeLocation)) {
                Process.Start(Application.StartupPath + '\\' + exeLocation);
                if (!stayOpenCheckBox.Checked) {
                    Application.Exit();
                }
            } else {
                MessageBox.Show("Executable not found!");
            }
        }
    }
}
