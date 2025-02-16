using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testgit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dddd, MMMM d, yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime today = DateTime.Today;

            TimeSpan difference = selectedDate - today;

            if (selectedDate < today)
            {
                MessageBox.Show("The selected date is in the past.");
            }
            else if (difference.Days <= 10)
            {
                MessageBox.Show("The selected date is near.");
            }
            else if (difference.Days <= 20)
            {
                MessageBox.Show("The selected date is convenient.");
            }
            else
            {
                MessageBox.Show("The selected date is very far.");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
