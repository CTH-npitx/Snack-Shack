using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace snackShack
{
    public partial class frm_snackInvent : Form
    {
        int editInd = -1;
        string bttnAddName = string.Empty;
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
            if (!File.Exists(txt_imagePath.Text))
            {
                MessageBox.Show("Please Select an image"); //error
                bttn_snackImage.Focus(); //focus on requesit controll
            }
            else if (txt_snackName.Text.Length == 0)
            {
                MessageBox.Show("Please Input a name");
                txt_snackName.Focus();
            }
            else if (nud_snackPrice.Value < constants.minPrice) //check if price is above minimum price defined in constants.cs
            {
                MessageBox.Show("Please enter a price that is more than 0");
                nud_snackPrice.Focus();
            }
            else
            {
                int editIndex2 = editInd;
                if(btn_add.Text == bttnAddName) {
                    editIndex2 = -1;
                }
                snackInvent snack = Program.addSnack(txt_snackName.Text, nud_snackPrice.Value, nud_snackQuantity.Value, txt_imagePath.Text, editInd);

                dgv_invent.Rows.Add(snack.name, snack.price, snack.amount, Image.FromFile(snack.imagepath), snack.imagepath, snack.index); //add into table
                toolStripStatusLabel1.Text = string.Format("Successfully added {0}", snack.name); //show name of snack added
                clearValues();
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
                        sw.WriteLine(snack.name + constants.entrySep + snack.price + constants.entrySep + snack.amount + constants.entrySep + snack.imagepath + constants.entrySep + snack.index); //write in csv format

                        count++; //increment count
                        toolStripStatusLabel1.Text = String.Format("Wrote {0} snacks to file", count); //show how many entries have been written so far
                    }
                }
            }
            catch (Exception ex) //catch exception
            {
                coreCommands.error("Error during file write", ex, false); //show error without exception message
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
                                //order is: snackname, price, quantity, imagepath, index

                            string line = sr.ReadLine(); //read line
                            string[] arr = line.Split(constants.entrySep); //split into an array based on the csv format

                            //populate class based on the contents of the file
                            snack.name = arr[0];
                            snack.price = double.Parse(arr[1]);
                            snack.amount = Int32.Parse(arr[2]);
                            snack.imagepath = arr[3];
                            snack.index = int.Parse(arr[4]); 

                            count++;
                            toolStripStatusLabel1.Text =
                                String.Format("Loaded {0} snacks from file", count); //show how many snacks loaded at this point
                            Program.snacks.Add(snack); //add class into list
                            dgv_invent.Rows.Add(snack.name, snack.price, snack.amount, Image.FromFile(snack.imagepath), snack.imagepath, snack.index); //add class to table
                        }
                    }
                }
            } catch (Exception ex) //catch exception
            {
                coreCommands.error("Error during file read", ex, false); //show error without exception message
            }

            clearValues();
            bttnAddName = btn_add.Text;
        }


        private void dgv_selectEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_invent == null)
            {
                return; //output nothing
            } //make sure there is something selected
            var row = dgv_invent.CurrentRow; //set a variable to the contents of the current row
            var indText = row.Cells[5].Value.ToString(); //get the index value from what was clicked
            var ind = int.Parse(indText);
            editInd = ind;
            var item = Program.snacks[ind];
            if (item != null)
            {
                txt_imagePath.Text = item.imagepath;
                pb_snackIcon.ImageLocation = item.imagepath;
                txt_snackName.Text = item.name;
                var price = Convert.ToDecimal(item.price);
                if (price >= constants.minPrice)
                {
                } else
                {
                    price = constants.minPrice;
                }
                nud_snackPrice.Value= price;
                var amount = Convert.ToDecimal(item.amount);
                if(amount >= constants.minQuantity)
                {

                } else
                {
                    amount = 0;
                }
                nud_snackQuantity.Value= amount;
            } //check if it exists
            btn_add.Text = "Edit Entry"; //change button text
        } //populate text boxes with the content of the selected row

        private void btn_clearEntry_Click(object sender, EventArgs e)
        {
            clearValues();
        }

        private void clearValues()
        {
            txt_imagePath.Text = "";
            txt_snackName.Text = "";
            nud_snackPrice.Value = constants.minPrice;
            nud_snackQuantity.Value = constants.minQuantity;
            pb_snackIcon.Image = null;
            if (dgv_invent.CurrentRow != null)
            {
                dgv_invent.ClearSelection(); //deselect row
            } //if a row is selected (which therefore means it was editing an entry), deselect all rows
            editInd = -1;
        }
    }
}