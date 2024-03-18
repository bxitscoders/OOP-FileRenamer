using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renamer.DTO
{
    internal class Parameter
    {
		private string _prefix;

		public string Prefix
		{
			get { return _prefix; }
			set { _prefix = value; }
		}

		private string _suffix;

		public string Suffix
		{
			get { return _suffix; }
			set { _suffix = value; }
		}


	}
}
