using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void frmMain_load(object sender, EventArgs e)
        { 
            dgv_inputUI.Rows.Add();
        }

        private void btn_appClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
