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
    public partial class Form2 : Form
    {
        public string[] user = new string[2] { "lukasz", "kuba" } ;
        public string[] pass = new string[2] { "1111", "2222" };
        public int activeUser;

        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelUserL.Text = user[activeUser];
        }
    }
}
