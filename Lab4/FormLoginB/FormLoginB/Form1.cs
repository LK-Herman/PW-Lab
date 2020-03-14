using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoginB
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
            using (MD5 md5Hash = MD5.Create())
            {

                string loginHash = GetMd5Hash(md5Hash, textBoxPass.Text);
                //textBoxPass.Text =(loginHash);

                for (int i = 0; i < 2; i++)
                {
                    if (textBoxUser.Text == F2.user[i])
                    {
                        userExist = true;
                        if (loginHash == F2.pass[i])
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            textBoxPass.Text = "";
        }


        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
