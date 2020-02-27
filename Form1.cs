using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_canceled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int airtemperature;
            int windChill;
            int snowfall;
            airtemperature = Convert.ToInt32(txtAirTemperature.Text);
            windChill = Convert.ToInt32(txtWindChill.Text);
            snowfall = Convert.ToInt32(txtNumberOfInches.Text);

            if (airtemperature < -25 || windChill < -35 || snowfall < 6) 
            {
                MessageBox.Show("School is likely to be cancelled if at least one of these is true", "Error");
            }
            else
            {

                MessageBox.Show("School is opened if at least one of these is false", "Error");

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
   
}
