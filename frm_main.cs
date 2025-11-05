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
        string rootPath = snackShack.coreCommands.path();

        string imageFolder = snackShack.coreCommands.path() + "Files" + constants.fileSepString() + "presetImages" + constants.fileSepString();
        string inventoryFile = snackShack.coreCommands.path() + "Files" + constants.fileSepString() + nameof(inventory) + ".csv";

        public frm_main()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = imageFolder;
            readInvent();
        }

        private void readInvent()
        {
            snackShack.files.read(inventoryFile, snackShack.constants.entrySep, snackShack.constants.min);
        }

        private void saveInvent()
        {
            snackShack.files.read(inventoryFile, snackShack.constants.entrySep, snackShack.constants.min);        }

        private void frmMain_load(object sender, EventArgs e)
        {

        }

        private void btn_appClose(object sender, EventArgs e)
        {
            if { confirm == true}
            {
                Application.Exit(); //close app
                saveInvent() //autosave
            } else { 
            
            };
        }

        private void btn_addItem_Click(object sender, EventArgs e) //add item
        {
           
        }

        private void picBox_icon_Click(object sender, EventArgs e)
        {
            string imagePath;        
            openFileDialog1.Filter = "All Files (*.*)|*.*|JPG (*.jpg*)|*.jpg"; //allow them to sort for a specific extension (the one utilized by this program), or any file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName;
            }
            
        }
    }
}
