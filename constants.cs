namespace snackShack
{
    internal static class constants //pre-defined constants
    {
        internal const int min = 4;
        internal const char entrySep = ',';
        const char fileSepChar_con = '\\'; //seperater in file paths
        internal const string preMadeErrorMsg = "I'm sorry dave, I'm afraid I can't do that"; //pre-made error message

        internal static string fileSepString() //give the seperation character as a string
        {
            return char.ToString(fileSepChar_con);
        }
        internal static char fileSepChar() //give the seperation character as a char
        {
            return fileSepChar_con;
        }

    }
}