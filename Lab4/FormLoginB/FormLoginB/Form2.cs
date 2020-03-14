using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoginB
{
    public partial class Form2 : Form
    {
        public string[] user = new string[2] { "lukasz", "kuba" } ;
        public string[] pass = new string[2] { "b59c67bf196a4758191e42f76670ceba", "934b535800b1cba8f96a5d72f72f1611" }; //{"1111";"2222"}
        public int activeUser;

        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelUserL.Text = user[activeUser];
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
