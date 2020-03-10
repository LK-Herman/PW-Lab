using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMR
{
    public partial class FormBMR : Form
    {
        public FormBMR()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMasa.Text="";
            textBoxWzrost.Text="";
            textBoxWiek.Text="";
        }

        private void buttonLicz_Click(object sender, EventArgs e)
        {
            if ((textBoxMasa.Text != "") && (textBoxWzrost.Text != "") && (textBoxWiek.Text != ""))
            {
                labelBMR.ForeColor = Color.Black;
                double waga = Convert.ToDouble(textBoxMasa.Text);
                double wzrost = Convert.ToDouble(textBoxWzrost.Text);
                double wiek = Convert.ToDouble(textBoxWiek.Text);

                //Debug.WriteLine(plec);
                //Debug.WriteLine(wzrost);
                //double bmi = (waga / (wzrost * wzrost));
                //label3.Text = bmi.ToString();
                double bmi = 0;
                if (comboBoxSex.Text == "Kobieta")
                {
                    bmi = (9.99 * waga) + (6.25 * wzrost) - (4.92 * wiek) - 161;
                    labelBMR.Text = bmi.ToString();
                    this.BackColor = System.Drawing.Color.White; 
                }
                if (comboBoxSex.Text == "Mężczyzna")
                {
                    bmi = (9.99 * waga) + (6.25 * wzrost) - (4.92 * wiek) + 5;
                    labelBMR.Text = bmi.ToString();
                    this.BackColor = Color.White;
                }
            }
            else
            {
                labelBMR.Text = "Brak danych";
                labelBMR.ForeColor = System.Drawing.Color.Red;
            }
        }

    }
}
