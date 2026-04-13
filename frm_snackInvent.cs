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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Threading;

namespace snackShack
{
    public partial class frm_snackInvent : Form
    {
        public frm_snackInvent()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = ""; // Wipe the status strip of all text
            nud_snackPrice.Minimum = constants.minPrice; // Set the minimum price to the constant defined in constants.cs
        }

        private void bttn_snackImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                // Set the open file dialog filter to allow for only image files, and configure it

            // Show the open file dialog and check if the user selected a file
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //set the text and image box to the selected image and file
            {
                txt_imagePath.Text = openFileDialog1.FileName;
                pb_snackIcon.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(!File.Exists(txt_imagePath.Text))
            {
                MessageBox.Show("Please Select an image"); //error
                bttn_snackImage.Focus(); //focus on requesit controll
            } 
            else if(txt_snackName.Text.Length == 0)
            {
                MessageBox.Show("Please Input a name");
                txt_snackName.Focus();
            } 
            else if(nud_snackPrice.Value < constants.minPrice) //check if price is above minimum price defined in constants.cs
            {
                MessageBox.Show("Please enter a price that is more than 0");
                nud_snackPrice.Focus();
            } 
            else
            {
                snackInvent snack = new snackInvent(); //make and set up class
                snack.name = txt_snackName.Text;
                snack.price = Convert.ToDouble(nud_snackPrice.Value);
                snack.amount = Convert.ToInt32(nud_snackQuantity.Value);
                snack.imagepath = txt_imagePath.Text;
                snack.index = Program.snacks.Count;

                Program.snacks.Add(snack); //add to list

                dgv_invent.Rows.Add(snack.name, snack.price, snack.amount, Image.FromFile(snack.imagepath), snack.imagepath, snack.index); //add into table

                toolStripStatusLabel1.Text = string.Format("Successfully added {0}", snack.name); //show name of snack added

                //reset
                txt_imagePath.Text = "";
                txt_snackName.Text = "";
                nud_snackPrice.Value = constants.minPrice;
                nud_snackQuantity.Value = 0;
                pb_snackIcon.Image = null;
            }
        }

        private void frm_snackInvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("snacks.csv")) {
                    int count = 0;
                    toolStripStatusLabel1.Text = String.Format("Wrote {0} snacks to file", count); //show current number of entries, which is 0.
                                                                                                    //If this is what you see when done, something went wrong
                    foreach (var snack in Program.snacks)
                    {
                        //snack name, price, quantity, imagepath
                        sw.WriteLine(snack.name + constants.entrySep + snack.price + constants.entrySep + snack.amount + constants.entrySep + snack.imagepath); //write in csv format

                        count++; //increment count
                        toolStripStatusLabel1.Text = String.Format("Wrote {0} snacks to file", count); //show how many entries have been written so far
                    }
                }
            }
            catch (Exception ex) //catch exception
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
                    toolStripStatusLabel1.Text =
                        String.Format("Proceeding to load snacks from file"); //if you see this, something went wrong...
                                                                                //It means that it failed before it loaded something
                    using (StreamReader sr = new StreamReader("snacks.csv"))
                    {
                        int count = 0;
                        while(!sr.EndOfStream)
                        {
                            snackInvent snack = new snackInvent(); //make new class
                                //order is: snackname, price, quantity, imagepath

                            string line = sr.ReadLine(); //read line
                            string[] arr = line.Split(constants.entrySep); //split into an array based on the csv format

                            //populate class based on the contents of the file
                            snack.name = arr[0];
                            snack.price = double.Parse(arr[1]);
                            snack.amount = Int32.Parse(arr[2]);
                            snack.imagepath = arr[3];

                            count++;
                            toolStripStatusLabel1.Text =
                                String.Format("Loaded {0} snacks from file", count); //show how many snacks loaded at this point
                            Program.snacks.Add(snack); //add class into list
                            dgv_invent.Rows.Add(snack.name, snack.price, snack.amount, Image.FromFile(snack.imagepath), snack.imagepath); //add class to table
                        }
                    }
                }
            } catch (Exception ex) //catch exception
            {
                MessageBox.Show("Error during file read", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
