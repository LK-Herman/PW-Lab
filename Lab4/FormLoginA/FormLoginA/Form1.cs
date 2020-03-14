using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoginA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            labelComment.Text = "";
            Form2 F2 = new Form2();
            bool userExist = false;
            bool access = false;

            for (int i=0; i<2; i++)
            {
                if(textBoxUser.Text == F2.user[i]) 
                {
                    userExist = true;
                    if (textBoxPass.Text == F2.pass[i])
                    {
                        access = true;
                        F2.activeUser = i;
                        labelComment.Text = "";
                    }
                    else labelComment.Text = "Nieprawidłowe HASŁO użytkownika!";

                }
            }
            if (!userExist) labelComment.Text = "Nieprawidłowa NAZWA użytkownika!";
            if (access) F2.Show();
        }
    }
}
