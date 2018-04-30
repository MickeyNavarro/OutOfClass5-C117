using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Almicke "Mickey" Navarro 
//CST117 
//Date: April 27, 2018
//This is my own work.

namespace OutOfClass5
{
    public partial class Magic8Ball : Form
    {
        public Magic8Ball()
        {
            InitializeComponent();
        }
        
        private void button_generate_Click(object sender, EventArgs e)
        {
            Outcome outcome = new Outcome();
            if (comboBox_month.SelectedIndex%2 == 0)
            {
                outcome.label_answer.Text = "Yes!";

            }
            else
            {
                outcome.label_answer.Text = "No!";
            }
            outcome.Show(); 
        }

        private void comboBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox_zsign.Items.Clear(); 

            if (comboBox_month.SelectedIndex == 0)
            {
                this.comboBox_zsign.Items.Add("Aquarius");
                this.comboBox_zsign.Items.Add("Capricorn");
            }
            else if (comboBox_month.SelectedIndex == 1)
            {
                this.comboBox_zsign.Items.Add("Aquarius");
                this.comboBox_zsign.Items.Add("Pices");
            }
            else if (comboBox_month.SelectedIndex == 2)
            {
                this.comboBox_zsign.Items.Add("Aries");
                this.comboBox_zsign.Items.Add("Pices");
            }
            else if (comboBox_month.SelectedIndex == 3)
            {
                this.comboBox_zsign.Items.Add("Aries");
                this.comboBox_zsign.Items.Add("Taurus");
            }
            else if (comboBox_month.SelectedIndex == 4)
            {
                this.comboBox_zsign.Items.Add("Gemini");
                this.comboBox_zsign.Items.Add("Taurus");
            }
            else if (comboBox_month.SelectedIndex == 5)
            {
                this.comboBox_zsign.Items.Add("Gemini");
                this.comboBox_zsign.Items.Add("Cancer");
            }
            else if (comboBox_month.SelectedIndex == 6)
            {
                this.comboBox_zsign.Items.Add("Leo");
                this.comboBox_zsign.Items.Add("Cancer");
            }
            else if (comboBox_month.SelectedIndex == 7)
            {
                this.comboBox_zsign.Items.Add("Leo");
                this.comboBox_zsign.Items.Add("Virgo");
            }
            else if (comboBox_month.SelectedIndex == 8)
            {
                this.comboBox_zsign.Items.Add("Libra");
                this.comboBox_zsign.Items.Add("Virgo");
            }
            else if (comboBox_month.SelectedIndex == 9)
            {
                this.comboBox_zsign.Items.Add("Libra");
                this.comboBox_zsign.Items.Add("Scorpio");
            }
            else if (comboBox_month.SelectedIndex == 10)
            {
                this.comboBox_zsign.Items.Add("Sagittarius");
                this.comboBox_zsign.Items.Add("Scorpio");
            }
            else
            {
                this.comboBox_zsign.Items.Add("Sagittarius");
                this.comboBox_zsign.Items.Add("Capricorn");
            }

            this.comboBox_zsign.Refresh();
        }
    }
}
