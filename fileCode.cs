
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System;

namespace snackShack.files
{
    internal static class files
    {
        internal static void Write(string filepath, char sep) 
        {
            bool status = File.Exists(filepath); //check if the file exists
            if (status || Program.debug)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(filepath))
                    {
                        foreach (var c in Program.inventory) //the loop for createing the contents which will be saved
                        {
                            //csv - comma seperated values
                            //firstname-lastname-email-phone-buisness-notes
                            string ind = (c.index + 1).ToString();
<<<<<<< Updated upstream
                            string cost = c.cost.ToString();
                            string line = c.name + sep + c.imagePath + sep +  //first and last name
                                cost + sep + ind;
=======
                            string line = c.firstname + sep + c.lastname + sep +  //first and last name
                                c.phone + sep + c.email + sep + c.buisness + sep + //contact information
                                c.notes + sep + ind; //notes
>>>>>>> Stashed changes
                            sw.WriteLine(line); //write the information to the line
                        }
                    } //streamwriter
                }
                catch (Exception ex)
                {
                    snackShack.coreCommands.error(Program.preMadeErrorMsg, ex, true); //show error
                }
            }
            else
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

                                coreCommands.error("error: below Max Length");
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
