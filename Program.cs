using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace snackShack
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_snackInvent());
        }

        internal static List<snackInvent> snacks = new List<snackInvent>();

        internal static snackInvent addSnack(string nameIn, decimal priceIn, decimal amountIn, string pathIn, int edit = -1)
        {
            bool isEdit = false;
            if (edit != -1)
            {
                isEdit = true;
            }
            snackInvent snack = null;
            string name = nameIn;
            double price = Convert.ToDouble(priceIn);
            Int32 amount = Convert.ToInt32(amountIn);
            string path = pathIn;

            if (isEdit)
            {
                snack = Program.snacks[edit];
            }
            else
            {
                snack = new snackInvent(); //make and set up class
            }
            var totalSnack = Program.snacks.Count;
            if (totalSnack >= edit && edit != -1)
            {
                Program.snacks[edit] = snack;
            }
            else
            {
                Program.snacks.Add(snack);
            }
            return snack;
        }
    }
}
