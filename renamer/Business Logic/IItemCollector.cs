using renamer.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renamer.Business_Logic
{
    internal interface IItemCollector
    {
       List<RenameItem> collectItems(string path);
    }
}
