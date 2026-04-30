
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System;

namespace snackShack
{
    internal static class files
    {
        #region I/O
        internal static void Write(string filepath, char sep) 
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    int count = 0;
                    toolStripStatusLabel1.Text = String.Format("Wrote {0} snacks to file", count); //show current number of entries, which is 0.
                                                                                                   //If this is what you see when done, something went wrong
                    foreach (var snack in Program.snacks)
                    {
                        //snack name, price, quantity, imagepath
                        sw.WriteLine(snack.name + constants.entrySep + snack.price + constants.entrySep + snack.amount + constants.entrySep + snack.imagepath + constants.entrySep + snack.index); //write in csv format

                        count++; //increment count
                        toolStripStatusLabel1.Text = String.Format("Wrote {0} snacks to file", count); //show how many entries have been written so far
                    }
                }
            }
            catch (Exception ex) //catch exception
            {
                coreCommands.error("Error during file write", ex, false); //show error without exception message
            }
        } //the write function
        
        internal static void read(string path, char sep, int min) //the read function
        {
            try
            {
                if (File.Exists(filePath))
                {
                    toolStripStatusLabel1.Text =
                        String.Format("Proceeding to load snacks from file"); //if you see this, something went wrong...
                                                                              //It means that it failed before it loaded something
                    var priceMin = decimal.ToDouble(constants.minPrice);
                    var amountMin = decimal.ToInt32(constants.minQuantity);
                    var priceMax = decimal.ToDouble(constants.maxPrice);
                    var amountMax = decimal.ToInt32(constants.maxQuantity);

                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        int count = 0;
                        while (!sr.EndOfStream)
                        {
                            snackInvent snack = new snackInvent(); //make new class
                                                                   //order is: snackname, price, quantity, imagepath, index

                            string line = sr.ReadLine(); //read line
                            string[] arr = line.Split(constants.entrySep); //split into an array based on the csv format

                            //assign to vars
                            string nameImport = arr[0];
                            double priceImport = double.Parse(arr[1]);
                            Int32 amountImport = int.Parse(arr[2]);
                            string pathImport = arr[3];
                            int indexImport = int.Parse(arr[4]);

                            //fix invalid numbers
                            if (priceImport < priceMin)
                            {
                                priceImport = priceMin;
                            } //ensure price is atleast the minimum
                            if (amountImport < amountMin)
                            {
                                amountImport = amountMin;
                            } //ensure amount is atleast the min
                            if (priceImport > priceMax)
                            {
                                priceImport = priceMax;
                            } //ensure the price is no more than the max
                            if (amountImport > amountMax)
                            {
                                amountImport = amountMax;
                            } //ensure the amount is no more than the max

                            //populate class based on the contents of the file
                            snack.name = nameImport;
                            snack.price = priceImport;
                            snack.amount = amountImport;
                            snack.imagepath = pathImport;
                            snack.index = indexImport;

                            count++;
                            toolStripStatusLabel1.Text =
                                String.Format("Loaded {0} snacks from file", count); //show how many snacks loaded at this point
                            Program.snacks.Add(snack); //add class into list
                            dgv_invent.Rows.Add(snack.name, snack.price, snack.amount, Image.FromFile(snack.imagepath), snack.imagepath, snack.index); //add class to table
                        }
                    }
                }
            }
            catch (Exception ex) //catch exception
            {
                coreCommands.error("Error during file read", ex, false); //show error without exception message
            }

            clearValues();
            bttnAddName = btn_add.Text;
        }
        #endregion
    } //the code for files
}