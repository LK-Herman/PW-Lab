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
    public partial class FormCard : Form
    {
        public FormCard()
        {
            InitializeComponent();
        }

        private void exitThisForm( object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) this.Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {

            FormShow2 FS2 = new FormShow2();
            FS2.name = textBoxfName.Text + " " + textBoxlName.Text;
            FS2.adr1 = textBoxAdres1.Text;
            FS2.adr2 = textBoxAdres2.Text;
            FS2.tel = textBoxTel.Text;
            FS2.email = textBoxEmail.Text;
            FS2.Text = FS2.name;
            
            FS2.Show();
        }

        
    }
}
