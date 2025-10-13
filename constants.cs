namespace snackShack.files
{
    internal static class constants
    {
        const char fileSepChar_con = '\\';
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