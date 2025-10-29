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
            int input = 50;
            dgv_inputUI.Rows.Add();
            dgv_inputUI.Rows[0].Height = input;
            dgv_inputUI.Height = input + header;
        }

        private void btn_appClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {

        }

        private void dgv_inputUI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string imagePath;
            if (e.ColumnIndex == 2)
            {
                openFileDialog1.Filter = "All Files (*.*)|*.*|JPG (*.jpg*)|*.jpg"; //allow them to sort for a specific extension (the one utilized by this program), or any file
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog1.FileName;
                }
            }
        }
    }
}
