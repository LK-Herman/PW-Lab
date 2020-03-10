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

namespace Pesel
{
    public partial class FormPesel : Form
    {
        public FormPesel()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            // SPRAWDZENIE: <11; >11; czy jest liczbą
            if (textBoxPesel.Text.Length < 11)
            {
                labelWynik.BackColor = Color.Crimson;
                labelWynik.ForeColor = Color.White;
                labelWynik.Text = "Za krótki nr PESEL";

            }
            else
            {
                if (textBoxPesel.Text.Length > 11)
                {
                    labelWynik.BackColor = Color.Crimson;
                    labelWynik.ForeColor = Color.White;
                    labelWynik.Text = "Za długi nr PESEL";
                }
                else
                {
                    int checkDigit = 0;         //licznik blednych znaków 
                    string bledneZnaki = "";    //zbiera błędne znaki

                    foreach (var ch in textBoxPesel.Text)  //sprawdza każdy znak, czy jest liczbą
                    {
                        if (Char.IsDigit(ch) == false)
                        {
                            checkDigit++;
                            if (ch == ' ') bledneZnaki = bledneZnaki + " spacja";   //wyjątek dla "niewidocznej" spacji
                            else bledneZnaki = bledneZnaki + " " + ch.ToString();
                        }
                    }
                    if (checkDigit != 0)  //jesli istnieją błędne znaki
                    {
                        labelWynik.BackColor = Color.Crimson;
                        labelWynik.ForeColor = Color.White;
                        labelWynik.Text = "Wprowadzono błędnych znaków: " + checkDigit + "  (" + bledneZnaki + ")";
                    }
                    //SPRAWDZENIE: Koniec
                    else  //Jesli pesel jest 11cyfrową liczbą to:
                    {
                        labelWynik.Text = "";
                        char[] peselCH = textBoxPesel.Text.ToCharArray();
                        int[] pes = new int[peselCH.Length];

                        for (int x = 0; x < 11; x++) pes[x] = Convert.ToInt32(Convert.ToString(peselCH[x]));

                        int wzor1 = pes[0] + 3 * pes[1] + 7 * pes[2] + 9 * pes[3] + pes[4] + 3 * pes[5] + 7 * pes[6] + 9 * pes[7] + pes[8] + 3 * pes[9];

                        wzor1 = wzor1 - ((wzor1 / 100) * 100);
                        wzor1 = wzor1 - ((wzor1 / 10) * 10);
                        wzor1 = 10 - wzor1;

                        if (wzor1 == pes[10])
                        {
                            labelWynik.BackColor = Color.DarkGreen;
                            labelWynik.ForeColor = Color.White;
                            labelWynik.Text = "Nr PESEL jest prawidłowy.";
                        }
                        else
                        {
                            labelWynik.BackColor = Color.Crimson;
                            labelWynik.ForeColor = Color.White;
                            labelWynik.Text = "Niestety podany nr PESEL jest nieprawidłowy.";
                        }
                    }
                }
            }

        }
    }
}
