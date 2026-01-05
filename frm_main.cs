using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization.Configuration;

namespace snackShack
{
    public partial class frm_main : Form
    {
        coreCommands.startupCommands.
        string rootPath = snackShack.coreCommands.path();

        string imageFolder = snackShack.coreCommands.path() + "Files" + constants.fileSepString() + "presetImages" + constants.fileSepString();
        string inventoryFile = snackShack.coreCommands.path() + "Files" + constants.fileSepString() + nameof(inventory) + ".csv";
        Image baseIcon = null;
        public frm_main()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = imageFolder; //set default path
            readInvent();
        }
        private void readInvent() //readInvent
        {
            snackShack.files.read(inventoryFile, snackShack.constants.entrySep, snackShack.constants.min); //this is a pre-setup read inventory function. That way reffernecing it is easier
        }

        private void saveInvent() //save inventory
        {
            snackShack.files.Write(inventoryFile, snackShack.constants.entrySep); //this is a pre - setup function for writing files, to make auto - saveing easier
        }

        private void frmMain_load(object sender, EventArgs e)
        {
            baseIcon = picBox_icon.InitialImage;
            picBox_icon.Image = baseIcon;
        }

        private void frmMain_close(object sender, FormClosingEventArgs e)
        {
            closeSystem(true);
            
        }

        private void btn_appClose(object sender, EventArgs e) //close app system
        {
            closeSystem();
        }

        private void btn_addItem_Click(object sender, EventArgs e) //add item
        {

        }

        private void picBox_icon_Click(object sender, EventArgs e) //click on image input
        {
            string imagePath; //the path
            openFileDialog1.Filter = "All Files (*.*)|*.*|JPG (*.jpg*)|*.jpg"; //allow them to sort for a specific extension (the one utilized by this program), or any file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName; //set the path
            } else
            {
                return;
            }
            picBox_icon.ImageLocation = imagePath;
            bool status = valid();
            toggleAdd(status);
        }
        #region Close System
        private void close()
        {
            bool confirm = false; //make confirm variable, default to false
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                confirm = true;
            }
            if (confirm == true)
            {
                Application.Exit(); //close app
            }
            else
            {

            }
        }
        private void closeSystem(bool viaMeneu = false)
        {
            if (viaMeneu)
            {
                saveInvent();
            } else
            {
                close();
            }
        }
        #endregion

        private void inpEnty_complete(object sender, EventArgs e)
        {
            bool status = valid();
            toggleAdd(status);
        }
        private void toggleAdd(bool valid)
        {
            bool status = addToolStripMenuItem.Enabled;
            if (status == valid)
            {
                return;
            } else
            {
                addToolStripMenuItem.Enabled = valid;
            }
        }
        private bool valid()
        {
            string inputText = txt_nameInput.Text;
            decimal price = num_snackCost.Value;
            decimal minPrice = constants.minimumPrice();
            bool valid = true;
            if (string.IsNullOrEmpty(inputText))
            {
                valid = false;
            }
            else if (price < minPrice)
            {
                valid = false;
            }
            else if (picBox_icon.Image == baseIcon)
            {
                valid = false;
            }
            
            return valid;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_icon.Image = baseIcon;
            num_snackCost.Value = 0;
            txt_nameInput.Text = string.Empty;
        }
    }
}
