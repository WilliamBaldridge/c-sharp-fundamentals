using System;
using System.IO;

namespace CSHarpFundamentals.beginners
{
    public class FileAndFileInfo
    {
        public FileAndFileInfo()
        {

            // Using File (static) causes security checks everytime, which FileInfo is only the first time (instance)

            var path = @"c:\\somefiles.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                //
            }

            //fileInfo.OpenRead // a pain will be shown another way later...

        }
    }
}
