﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    public partial class patientForm : Form
    {
        public patientForm(String lastNameQuery)
        {
            InitializeComponent();

            System.IO.StreamReader file = new System.IO.StreamReader("Test.txt");

           String lastName = file.ReadLine();

            while (lastName != lastNameQuery)
            {
                lastName = file.ReadLine();
            }
            String firstName = file.ReadLine();
            String middleName = file.ReadLine();
            String dateOfBirth = file.ReadLine();

            lastNameTextBox.Text = lastName;
            firstNameTextBox.Text = firstName;
            middleNameTextBox.Text = middleName;
            dobTextBox.Text = dateOfBirth;

            file.Close();
        }
        //when pressed will close program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void patientForm_Load(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
