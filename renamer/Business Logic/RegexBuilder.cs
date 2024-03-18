using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace renamer.Business_Logic
{
    internal class RegexBuilder : IRegexBuilder
    {
        private string _prefix;
        private string _suffix;
        private string _matchpattern;
        private string _targetpattern;
        private string regexString;

        public string Prefix { get => _prefix; set => _prefix = value; }
        public string Suffix { get => _suffix; set => _suffix = value; }
        public string MatchPattern { get => _matchpattern; set => _matchpattern = value; }
        public string TargetPattern { get => _targetpattern; set => _targetpattern = value; }

        public Regex buildRegex()
        {
            regexString = string.Empty;
            return new Regex(regexString);
        }

        public string getRegexString()
        {
            return regexString;
        }
    }
}
