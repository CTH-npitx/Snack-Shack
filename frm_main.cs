using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        private void tsb_close(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}