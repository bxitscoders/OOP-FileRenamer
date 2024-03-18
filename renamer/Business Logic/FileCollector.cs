using renamer.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renamer.Business_Logic
{
    internal class FileCollector : IItemCollector
    {
        const int maxDepth = 10;

        public List<RenameItem> collectItems(string dir)
        {
            if (Directory.Exists(dir))
            {
                List<RenameItem> files = new List<RenameItem>();
                crawlDir(dir, files, 0);
                Console.WriteLine("Foud Files in " + dir);
                foreach (RenameItem item in files)
                {
                    Console.WriteLine(item.Name);
                }
                return files;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        private void crawlDir(string dir, List<RenameItem> files, int depth)
        {
            if (depth < maxDepth) {
                foreach (string fileContents in Directory.GetFiles(dir))
                {
                    RenameItem item = new RenameItem();
                    item.Path = fileContents;
                    item.Name = Path.GetFileName(fileContents);
                    files.Add(item);
                }

                foreach (string dirContents in Directory.GetDirectories(dir))
                {
                    crawlDir((string)dirContents, files, depth+1);
                }
            }
            else
            {
                return;
            }
           
        }
    }
}
