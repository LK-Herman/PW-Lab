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

namespace BMIwyklad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                label3.ForeColor = Color.White;
                double waga = Convert.ToDouble(textBox1.Text);
                double wzrost = Convert.ToDouble(textBox2.Text);
                //Debug.WriteLine(waga);
                //Debug.WriteLine(wzrost);
                double bmi = (waga / (wzrost * wzrost));
                label3.Text = bmi.ToString();
            }
            else
            {
                label3.Text = "Brak danych";
                label3.ForeColor = Color.Red;            
            }
        }

       
    }
}
