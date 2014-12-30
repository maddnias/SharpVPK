using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVPK.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var archive = new VpkArchive();
            archive.Load(@"G:\Steam\SteamApps\common\dota 2 beta\dota\pak01_dir.vpk");

            //foreach(var dir in archive.Directories)
            //    foreach(var entry in dir.Entries)
            //        if (entry.HasPreloadData)
            //        {
 
            //        }
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
