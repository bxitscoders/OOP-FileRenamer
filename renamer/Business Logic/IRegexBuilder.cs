using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace renamer.Business_Logic
{
    internal interface IRegexBuilder
    {
        string Prefix { get; set; }
        string Suffix { get; set; }
        string MatchPattern { get; set; }
        string TargetPattern { get; set; }

        Regex buildRegex();
        string getRegexString();
    }
}
