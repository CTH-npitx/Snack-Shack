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
    public partial class frmMain : Form
    {
        public frmMain()
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
        }

        private void tsb_close(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
