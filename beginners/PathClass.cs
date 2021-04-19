using System;
using System.IO;

namespace CSHarpFundamentals.beginners
{
    public class PathClass
    {
        public PathClass()
        {

            var path = @"c:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));

            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name:" + Path.GetDirectoryName(path));


        }
    }
}
