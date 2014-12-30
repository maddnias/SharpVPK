SharpVPK:
========

A memory-friendly and fast parser for Valve's VPK files created in C#
========

Example usage

```cs
    var archive = new VpkArchive();
    archive.Load(@"vpk_file_path.vpk");
    
    foreach(var directory in archive.Directories)
    	foreach (var entry in directory.Entries)
    		Console.WriteLine(entry.ToString());
    
    Console.WriteLine("Done");
    Console.ReadLine();
```

which will return something similar to

![Image of Yaktocat](http://puu.sh/dQswx/af4843c5c7.png)