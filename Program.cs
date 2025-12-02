using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
            Application.Run(new frm_main());
        }
        internal const bool debug = true; //global var to controll default for debugs
        internal static List<inventory> inventory = new List<inventory>(); //makes a collection that refferences the class that will store information
    }

    internal static class coreCommands
    {
        internal static class files
        {
            #region I/O
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
                                        index = Convert.ToInt32(entry[3]) - 1 //any guesses?
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
            #endregion
        } //the code for files

        internal static void error(string message, Exception ex = null, bool revealException = false)
        {
            string msg = message; //what message to display
            if (revealException) //put the toggle
            {
                msg = msg + ": " + ex.Message; //the message
            }//a bool to toggle if the exception code should be included in the error message
            MessageBox.Show(msg); //show the message
        } //this is for error messages. the text is mandatory, but the
          //rest isn't necessary. if you don't provide an exception, it won't display one. If you provide an error, it will default to "hide error".
          // WARNING: If you provide a boolean, you can controll if it's hidden. If you provide a boolean but no error, well, it won't work righ

        internal static string path()
        {
            var pathSpliter = '\\'; //part between paths
            var loc = AppDomain.CurrentDomain.BaseDirectory; //get the current domain
            var comps = loc.Split('\\'); //array of path after being split
            var len = comps.Length; //length of path
            var completeLoc = string.Empty; //blank variable for path
            for (var i = 0; i < len-3; i++) //repeat by the length minus 2, which will lead to it excluding the 2 folders that are unwanted
            {
                var comp = comps[i];
                completeLoc = completeLoc + comp + char.ToString(pathSpliter); //add next part to path
            }
            return completeLoc; //output path
        } //derive the path of the base file
    } //base commands to aid in everything
}