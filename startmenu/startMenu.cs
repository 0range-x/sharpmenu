using System;
using System.IO;

namespace startmenu
{
    internal class startMenu
    {
        static void Main(string[] args)
        {
            string path = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
 
            foreach (var item in dirInfo.GetFileSystemInfos())
            {
                if (item.Attributes.HasFlag(FileAttributes.Directory) || item.Extension.Equals(".lnk"))
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
