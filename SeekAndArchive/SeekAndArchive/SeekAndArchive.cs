using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAndArchive
{
    class SeekAndArchive
    {
        private static List<FileInfo> resultFiles;

        static void Main(string[] args)
        {
            FileSearchEngine fileSearchEngine = new FileSearchEngine(args[0], args[1]);
            resultFiles = fileSearchEngine.Search();

            foreach (FileInfo fileInfo in resultFiles)
            {
                Console.WriteLine(fileInfo.FullName);
            }

            Console.ReadKey();
        }
    }
}
