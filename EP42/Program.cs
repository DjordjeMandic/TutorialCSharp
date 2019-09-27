using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EP42
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var lokacijaNasegFoldera = @"c:\temp\NasFolder";
            if (Directory.Exists(lokacijaNasegFoldera))
            {
                Console.WriteLine("Folder vec postoji");
            }
            else
            {
                Directory.CreateDirectory(lokacijaNasegFoldera);
            }

            Console.ReadLine();

            Directory.Delete(lokacijaNasegFoldera, true); // true znaci da brise i sve iz foldera, prvo brise sve iz foldera pa onda fodler.

            Console.ReadLine();

            Directory.Move(@"C:\temp\bla", @"c:\temp\test\2");*/

            Console.ReadLine();
            /*var folderi = Directory.GetDirectories(@"C:\temp");
            foreach(var dirpath in folderi)
            {
                Directory.Delete(dirpath);
            }*/
            var currDir = Directory.GetCurrentDirectory();
            Console.WriteLine(currDir);
            Console.WriteLine(Directory.GetDirectoryRoot(currDir));
            Console.WriteLine(Directory.GetParent(currDir));
            Console.WriteLine(Directory.GetCreationTime(currDir));

            var lokacijaTestFodlera = Path.Combine(currDir, "Test");
            Console.WriteLine(Directory.GetCreationTime(lokacijaTestFodlera));
            Directory.CreateDirectory(lokacijaTestFodlera);
            Directory.SetCreationTime(lokacijaTestFodlera, new DateTime(1999, 8, 14, 15, 12, 58));
            Console.WriteLine(Directory.GetCreationTime(lokacijaTestFodlera));
            var fajlovi = Directory.GetFiles(currDir);
            foreach(var fajl in fajlovi)
            {

                Console.WriteLine(fajl);
            }

            var diskovi = Directory.GetLogicalDrives();
            foreach(var disk in diskovi)
                Console.WriteLine(disk);
        }
    }
}
