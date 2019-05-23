using System;
using System.IO;
using System.Collections.Generic;

namespace Arquivos
{
    class DirectoryAndDirectoryInfo
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\myfolder";

            try
            {
                //pode usar o 'var' no lugar de IEnumerable sem precisar chamar o System.Collections.Generic
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string s in files)

                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder"); // ou \\newfolder
            }
            catch (IOException e)
            {
                Console.WriteLine("An Error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
