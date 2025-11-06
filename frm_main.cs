using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Runtime.InteropServices;
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
            openFileDialog1.InitialDirectory = imageFolder; //set default path
            readInvent();
        }

        private void readInvent()
        {
            snackShack.files.read(inventoryFile, snackShack.constants.entrySep, snackShack.constants.min);
        }

        private void frmMain_load(object sender, EventArgs e) //on load
        {

        }

        private void btn_appClose(object sender, EventArgs e) //close button
        {
            Application.Exit(); //close app
        }
        string rootPath = string.Empty;
        string inventoryFile = string.Empty;
        string imageFolder = string.Empty;
        const char fileSepChar = '\\';
        string fileSep = char.ToString(fileSepChar);
        //remove close (based on https://csharphelper.com/howtos/howto_remove_close_x.html )
        #region removeClose
        // Declare User32 constants and methods.
        private const int MF_BYPOSITION = 0x400;
        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        // Remove the X button.
        void removeClose()
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int num_menu_items = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, num_menu_items - 1, MF_BYPOSITION); // Remove Close
            RemoveMenu(hMenu, num_menu_items - 2, MF_BYPOSITION); // Remove Minimise
        }
        #endregion
        private void frmMain_load(object sender, EventArgs e)
        {
            rootPath = snackShack.coreCommands.path();
            inventoryFile = rootPath + nameof(inventory) + ".csv";
            imageFolder = rootPath + "presetImages" + fileSep;
            removeClose();
        }

        private void picBox_icon_Click(object sender, EventArgs e) //click on image input
        private void btn_appClose(object sender, EventArgs e)
        {
            string imagePath; //the path
            openFileDialog1.Filter = "All Files (*.*)|*.*|JPG (*.jpg*)|*.jpg"; //allow them to sort for a specific extension (the one utilized by this program), or any file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName; //set the path
            }
            
            Application.Exit();
        }

    }
}
