using System;
using System.Windows.Forms;

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
        }

        private void tsb_close(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
