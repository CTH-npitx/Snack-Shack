using System.Drawing;

namespace snackShack
{
    internal static class constants //pre-defined constants
    {
        const char fileSepChar_con = '\\'; //seperater in file paths
        internal const int min = 4; //length of entries
        internal const char entrySep = ','; //seperation character
        internal const string preMadeErrorMsg = "I'm sorry dave, I'm afraid I can't do that"; //pre-made error message
        internal const double minPrice = 0.05;
        internal static string fileSepString() //give the seperation character as a string
        {
            return char.ToString(fileSepChar_con);
        }
        internal static char fileSepChar() //give the seperation character as a char
        {
            return fileSepChar_con;
        }
        internal static decimal minimumPrice()
        {
            return (decimal)minPrice;
        }
    }
}