using System;
using System.IO;

namespace Arquivos
{
    class ExemploDeStreamWriter
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\Temp\file1.txt";
            string targetPath = @"C:\Temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }                  
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
//