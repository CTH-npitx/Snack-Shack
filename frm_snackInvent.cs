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
            toolStripStatusLabel1.Text = "";
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
            if(!File.Exists(txt_imagePath.Text))
            {
                MessageBox.Show("Please Select an image");
                bttn_snackImage.Focus();
            } else if(txt_snackName.Text.Length == 0)
            {
                MessageBox.Show("Please Input a name");
                txt_snackName.Focus();
            } else if(nud_snackPrice.Value == 0)
            {
                MessageBox.Show("Please enter a price that is more than 0");
                nud_snackPrice.Focus();
            } else
            {
                snackInvent snack = new snackInvent();
                snack.name = txt_snackName.Text;
                snack.price = Convert.ToDouble(nud_snackPrice.Value);
                snack.amount = Convert.ToInt32(nud_snackQuantity.Value);
                snack.imagepath = txt_imagePath.Text;
                Program.snacks.Add(snack);

                dgv_invent.Rows.Add(snack.name, snack.price, snack.amount, Image.FromFile(snack.imagepath), snack.imagepath);


                //reset
                txt_imagePath.Text = "";
                txt_snackName.Text = "";
                nud_snackPrice.Value = 0;
                nud_snackQuantity.Value = 0;
                pb_snackIcon.Image = null;
            }
        }

        private void nud_snackQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_snackInvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("snacks.csv")) { 
                    foreach(var snack in Program.snacks)
                    {
                        //snack name, price, quantity, imagepath
                        sw.WriteLine(snack.name + "," + snack.price + "," + snack.amount + "," + snack.imagepath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during file write", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frm_snackInvent_Load(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists("snacks.csv"))
                {
                    using (StreamReader sr = new StreamReader("snacks.csv"))
                    {
                        while(!sr.EndOfStream)
                        {
                            
                            snackInvent snack = new snackInvent();
                        }
                    }
                }
            }
        }
    }
}
