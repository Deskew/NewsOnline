using System.IO;

namespace NewsOnline.App_Code
{
    /// <summary>
    /// Summary description for IOFunctions
    /// </summary>
    public class IOFunctions
    {
        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}