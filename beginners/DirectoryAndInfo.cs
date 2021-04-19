using System;
using System.IO;

namespace CSHarpFundamentals.beginners
{
    public class DirectoryAndInfo
    {
        public DirectoryAndInfo()
        {

            Directory.CreateDirectory(@"c:temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);

            foreach (var file in files)
                Console.WriteLine(file);


            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);

            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");




            // Differences like File and FileInfo

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();


        }
    }
}
