using renamer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renamer.Business_Logic
{
    internal interface IWriter
    {
       void writeFileNames(List<RenameItem> items);
    }
}
