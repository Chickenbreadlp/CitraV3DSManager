using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CitraV3DSManager
{
    public partial class setName : Form
    {
        public string title = "";
        public string output = "";
        public bool setOutput = false;

        public setName()
        {
            InitializeComponent();
        }

        private void setName_Load(object sender, EventArgs e)
        {
            Text = title;
            tb_name.Text = "";
            setOutput = false;
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("Virtual System Name can't be Empty!", "Name Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Directory.Exists(Path.Combine(Program.mW.CitraFolder, "v3DS", tb_name.Text)) || tb_name.Text == Program.mW.cName)
            {
                MessageBox.Show("Virtual System Name already exists!", "Name Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                output = tb_name.Text;
                setOutput = true;
                Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
