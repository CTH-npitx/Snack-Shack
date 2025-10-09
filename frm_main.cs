using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization.Configuration;

namespace snackShack
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        string rootPath = string.Empty;
        string inventoryFile = string.Empty;
        string imageFolder = string.Empty;
        const char fileSepChar = '\\';
        string fileSep = char.ToString(fileSepChar);
        private void frmMain_load(object sender, EventArgs e)
        {
            rootPath = snackShack.coreCommands.path();
            inventoryFile = rootPath + nameof(inventory) + ".csv";
            imageFolder = rootPath + "presetImages" + fileSep;
            dgv_invent.Rows.Add();
            openFileDialog1.InitialDirectory = imageFolder;
        }

        private void btn_appClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_invent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_invent_CellClick(object sender, DataGridViewCellEventArgs e)
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
