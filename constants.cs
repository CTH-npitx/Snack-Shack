namespace snackShack.files
{
    internal static class constants
    {
        const char fileSepChar_con = '\\';
        const string includedPreMade = "I'm sorry dave, I'm afraid I can't do that"; //pre-made error message
        internal static string preMadeErrorMsg()
        {
            return includedPreMade;
        }
        internal static string fileSepString()
        {
            return char.ToString(fileSepChar_con);
        }
        internal static char fileSepChar()
        {
            return fileSepChar_con;
        }

    }
}