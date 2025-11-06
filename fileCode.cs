
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System;

namespace snackShack
{
    internal static class files
    {
        internal static void Write(string filepath, char sep) 
        {
            bool status = File.Exists(filepath); //check if the file exists
            if (status || Program.debug) //if file exists, or debug is active, run system
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(filepath)) //utilize the file path to find the file
                    {
                        foreach (var c in Program.inventory) //the loop for createing the contents which will be saved
                        {
                            //csv - comma seperated values
                            //name-imagepath-cost-index
                            string ind = (c.index + 1).ToString(); //indux to string
                            string cost = c.cost.ToString(); //cost to string
                            string line = c.name + sep + c.imagePath + sep +  //combine string
                                cost + sep + ind;
                            sw.WriteLine(line); //write the information to the line
                        }
                    } //streamwriter
                }
                catch (Exception ex) //find if exception
                {
                    snackShack.coreCommands.error(constants.preMadeErrorMsg, ex, true); //show error
                }
            }
            else //say if no file
            {
                snackShack.coreCommands.error("File Not Found"); //show error
            }
        } //the write function
        
        internal static void read(string path, char sep, int min) //the read function
        {
            bool status = File.Exists(path); //check if the file exists
            if (status || Program.debug) //check if there
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path)) //make stringreader
                    {
                        //csv - comma seperated values 
                        //firstname-lastname-email-phone-buisness-notes
                        while (!sr.EndOfStream) //add each line to it one by one
                        {
                            string item = sr.ReadLine(); //gets the next line of text from the file
                            var entry = item.Split(sep); //splits it by the seperator
                            if (entry.Length >= min)
                            {
                                inventory c = new inventory //make new constact
                                {
                                    name = entry[0], //put the realevent input into the releavent field
                                    imagePath = entry[1], //same
                                    cost = Convert.ToInt32(entry[2]), //same
                                    index = Convert.ToInt32(entry[3]) -1 //any guesses?
                                };
                                Program.inventory.Add(c); //add to list
                            }
                            else
                            {

                                coreCommands.error("error: below Max Length"); //show error during read
                            }
                        }
                    }
                }
                catch (Exception ex) //show if exception
                {
                    MessageBox.Show("error" + ex.Message); //show error

                }
            }
            else
            {
                MessageBox.Show("file not found"); //show error

            }
        }
    } //the code for files
}
