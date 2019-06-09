using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitraV3DSManager
{
    public partial class firstSetup : Form
    {
        public string setName = "Current";

        public firstSetup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("The v3DS Name can't be empty!", "Name Empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                setName = tb_name.Text;
                Close();
            }
        }
    }
}
