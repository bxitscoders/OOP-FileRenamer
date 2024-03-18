using renamer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace renamer.Business_Logic
{
    internal class FileRenamer
    {
        public FileRenamer() {
        }

        public void renameFiles(string path, string[] args, IItemCollector collector) 
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Command Usage: renamer mode args");
            }
            else
            {
                ParamUtils paramUtils = new ParamUtils(args);
                if (paramUtils.Valid) {
                    IRegexBuilder regexBuilder = new RegexBuilder();
                    switch (paramUtils.Mode)
                    {
                        case commandType.full:
                            List<RenameItem> items = collector.collectItems(Environment.CurrentDirectory);
                            regexBuilder.TargetPattern = args[1];
                            regexBuilder.MatchPattern = args[2];
                            applyRename(items, regexBuilder);
                            break;
                        case commandType.prefix:

                            break;
                        default: 
                            break;
                    }
                }
            }
        }

        private void applyRename(List<RenameItem> itmes, IRegexBuilder regex) { 
            Writer writer = new Writer();
            foreach (RenameItem item in itmes) {
                if (regex.buildRegex().IsMatch(item.Name)) {
                    Regex.Replace(item.Name, regex.getRegexString());
                }
            }
            writer.writeFileNames(itmes);
        }
    }
}
