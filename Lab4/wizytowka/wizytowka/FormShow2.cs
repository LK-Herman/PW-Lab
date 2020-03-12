using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wizytowka
{
    public partial class FormShow2 : Form
    {
        public string name, adr1, adr2, tel, email;
        

        private void q_quit(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'q' || e.KeyChar == (char)Keys.Escape) this.Close();
        }

        private void FormShow2_Load(object sender, EventArgs e)
        {
            if (name.Length > 2)
            {
                labelName.Text = name;
                labelAdres1.Text = adr1;
                labelAdres2.Text = adr2;
                labelTel.Text = tel;
                labelEmail.Text = email;
            }
        }

        private void labelName_MouseHover(object sender, EventArgs e)
        {
            labelName.ForeColor = Color.FromArgb(255, 230, 128);
        }
        private void labelName_MouseLeave(object sender, EventArgs e)
        {
            labelName.ForeColor = Color.White;
        }

        public FormShow2()
        {
            InitializeComponent();
        }
    }
}
