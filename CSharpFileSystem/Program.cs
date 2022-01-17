using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"D:\Temp\Demos\FileSystem";
            string[] dirs = Directory.GetDirectories(rootPath);
            foreach(string dir in dirs)
            {
                Console.WriteLine(dir);
            }

            Console.WriteLine("Get the SubFolders with the Search Option");
            string[] subDirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            foreach (string dir in subDirs)
            {
                Console.WriteLine(dir);
            }

            Console.WriteLine("Get the Files with the Search Option with Top Directory Only");
            string[] topFiles = Directory.GetFiles(rootPath, "*", SearchOption.TopDirectoryOnly);
            foreach (string file in topFiles)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("Get the Files with the Search Option with AllDirectories Only");
            string[] allFiles = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            foreach (string file in allFiles)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("Get the FileName from the path with the Search Option with AllDirectories Only");
            string[] files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            Console.WriteLine("Get the FileName without extension with the Search Option with AllDirectories Only");
            string[] filesExt = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            foreach (string file in filesExt)
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }

            Console.WriteLine("Get the FileName with full path extension with the Search Option with AllDirectories Only");
            string[] filesFullPath = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            foreach (string file in filesFullPath)
            {
                Console.WriteLine(Path.GetFullPath(file));
            }

            Console.WriteLine("Get DirectoryName with the Search Option with AllDirectories Only");
            string[] filesDirectoryName = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            foreach (string file in filesDirectoryName)
            {
                Console.WriteLine(Path.GetDirectoryName(file));
            }

            Console.WriteLine("Get File Info with the Search Option with AllDirectories Only along with Length");
            string[] filesInfo = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            foreach (string file in filesInfo)
            {
                var info = new FileInfo(file);
                Console.WriteLine( $"{Path.GetFileName(file)} : {info.Length} bytes");
            }

            Console.WriteLine("Check if the directory exists");
            string newPath = @"D:\Temp\Demos\FileSystem\SubFolderC";

            bool directoryExists = Directory.Exists(newPath);

            if(directoryExists)
            {
                Console.WriteLine("The directory exists");
            }
            else
            {
                Console.WriteLine("The directory does not exist");
                Directory.CreateDirectory(newPath);
            }

            string[] filesRootPath = Directory.GetFiles(rootPath);
            string destinationFolder = @"D:\Temp\Demos\FileSystem\SubFolderA";
            foreach (string file in filesRootPath)
            {
                File.Copy(file, $"{destinationFolder} { Path.GetFileName(file) }", true);
               // Console.WriteLine(file);
            }

            Console.ReadLine();
        }
    }
}
