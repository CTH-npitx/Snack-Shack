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

namespace snackShack
{
    public partial class frm_snackInvent : Form
    {
        public frm_snackInvent()
        {
            InitializeComponent();
        }

        private void bttn_snackImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if(openFileDialog1.ShowDialog() == DialogResult.OK) { 
                txt_imagePath.Text = openFileDialog1.FileName;
                pb_snackIcon.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(File.Exists(txt_imagePath.Text))
            {
                MessageBox.Show("Please Select an image");
                bttn_snackImage.Focus();
            } else if(txt_snackName.Text.Length == 0)
            {
                MessageBox.Show("Please Input a name");
                txt
            }
        }
    }
}
