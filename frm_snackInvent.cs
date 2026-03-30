using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snackShack
{
    public partial class frm_snackInvent : Form
    {
        public frm_snackInvent()
        {
            InitializeComponent();
        }

        private void bttn_snackImage_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg,*.jpeg,*.png,*.gif,*bmp)|*.jpg,*.jpeg,*.png,*.gif,*.bmp";
            if(openFileDialog1.ShowDialog() == DialogResult.OK) { }
        }
    }
}
