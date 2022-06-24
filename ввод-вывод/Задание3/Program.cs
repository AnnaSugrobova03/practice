using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace Задание3
{
    class Program
    {
        public static string ReadAllText(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            {
                var encoding = new UTF8Encoding(true);
                var reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\Desktop\Практика";
            Console.Write("Введите название файла: ");
            string fileName = Console.ReadLine();

            foreach (string findedFile in Directory.EnumerateFiles(path, fileName, SearchOption.AllDirectories))
            {
                FileInfo FI;
                try
                {
                    FI = new FileInfo(findedFile);
                    Console.WriteLine(FI.Name + " " + FI.FullName + " " + FI.Length + " байт" + " Создан: " + FI.CreationTime);
                    Process.Start(findedFile);
                    FileStream fs1 = new FileStream(findedFile, FileMode.OpenOrCreate);
                    FileStream fs2 = File.Create(findedFile);
                    GZipStream zip = new GZipStream(fs2, CompressionMode.Compress);
                    fs1.CopyToAsync(zip);
                    Console.ReadKey();
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
