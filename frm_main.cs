using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            openFileDialog1.InitialDirectory = imageFolder; //set default path
            readInvent();
        }

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
        private void readInvent() //readInvent
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int num_menu_items = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, num_menu_items - 1, MF_BYPOSITION); // Remove Close
            RemoveMenu(hMenu, num_menu_items - 2, MF_BYPOSITION); // Remove Minimise
        }
        #endregion

        private void saveInvent() {
            snackShack.files.Write(inventoryFile, snackShack.constants.entrySep); 
         }//save inventory
        private void readInvent()
        {
            snackShack.files.read(inventoryFile, snackShack.constants.entrySep, snackShack.constants.min);
        } //read inventory

        private void frmMain_load(object sender, EventArgs e) //on load
        {

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
            }

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
                imagePath = openFileDialog1.FileName; //set the path
            }
            
        }

        private void frmMain_close(object sender, FormClosingEventArgs e)
        {
            closesystem();
        }
        #endregion
    }
}
