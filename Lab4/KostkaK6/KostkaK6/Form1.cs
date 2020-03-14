using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostkaK6
{
    public partial class Form1 : Form
    {
        public Random roll = new Random();
        public Image diceImage;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void RollTheDice(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 188, 0);
            int oneRoll = roll.Next(1, 6);
            labelScore.Text = Convert.ToString(oneRoll);
            diceImage = Image.FromFile("img/dice-" + oneRoll + ".png");
            pictureBoxK6.Image = diceImage;
            this.Memo_Click(sender, e);
        }

        private void copyScoreToClip(object sender, EventArgs e)
        {
            Clipboard.SetText(labelScore.Text);
            this.BackColor = Color.FromArgb(155, 200, 0);
        }



        private void Memo_Click(object sender, EventArgs e)
        {
            labelMemo.Text += labelScore.Text + " ";
            if (labelMemo.Text.Length > 49) labelMemo.Text = "ZAPAMIĘTANE RZUTY: "+ labelScore.Text+" ";
        }

        private void keyMenu(object sender, KeyPressEventArgs e)
            {
                this.KeyPreview = true;

                switch (e.KeyChar)
                {
                    case 'q':
                        this.Close();
                        break;
                    case (char)Keys.Escape:
                        this.Close();
                        break;
                    case 'r':
                        this.RollTheDice(sender, e);
                        break;
                    case 'z':
                        
                        break;
                    case 'c':
                        this.labelMemo.Text = "ZAPAMIĘTANE RZUTY: ";
                        break;
                    case 'k':
                        this.copyScoreToClip(sender, e);
                        
                        break;
            }
            }

            
       
       
    }
}
