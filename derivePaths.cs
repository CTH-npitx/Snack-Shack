using System.IO;

namespace snackShack
{
    internal static class derivePaths //derive different paths
    {
        internal static string baseFolder(string folderName = constants.storageFolder)
        {
            string parentFolder = coreCommands.path();
            parentFolder = Path.Combine(parentFolder, folderName);
            return parentFolder;
        }
    }
}