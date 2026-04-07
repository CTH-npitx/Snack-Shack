
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System;

namespace snackShack.files
{
    internal static class files
    {
        internal static void write() {
            try
            {
                using (StreamWriter sw = new StreamWriter("snacks.csv"))
                {
                    foreach (var snack in Program.snacks)
                    {
                        //snack name, price, quantity, imagepath
                        sw.WriteLine(snack.name + "," + snack.price + "," + snack.amount + "," + snack.imagepath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during file write", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        internal static void read()
        {
            try
            {
                if (File.Exists("snacks.csv"))
                {
                    using (StreamReader sr = new StreamReader("snacks.csv"))
                    {
                        while (!sr.EndOfStream)
                        {
                            snackInvent snack = new snackInvent();
                            //snackname, price, quantity, imagepath
                            string line = sr.ReadLine();
                            string[] arr = line.Split(',');
                            snack.name = arr[0];
                            snack.price = double.Parse(arr[1]);
                            snack.amount = Int32.Parse(arr[2]);
                            snack.imagepath = arr[3];

                            Program.snacks.Add(snack);
                            dgv_invent.Rows.Add(snack.name, snack.price, snack.amount, Image.FromFile(snack.imagepath), snack.imagepath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during file read", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    } //the code for files
}
