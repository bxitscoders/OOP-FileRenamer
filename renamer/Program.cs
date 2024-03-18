using renamer.Business_Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renamer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           FileRenamer renamer = new FileRenamer();
           string dir = Environment.CurrentDirectory;
           renamer.renameFiles(dir, args, new FileCollector());
        }
    }
}
