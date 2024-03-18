using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renamer.Business_Logic
{
    internal class ParamUtils
    {
        private string[] args;
        private commandType _mode;

        public  commandType Mode
        {
            get { return _mode; }
        }
        private bool _valid;

        public bool Valid
        {
            get { return _valid; }
        }



        public ParamUtils(string[] args)
        {
            this.args = args;
            isValid();
        }

        private void setMode()
        {
            Enum.TryParse<commandType>(args[0], true,out _mode);
        }

        private void isValid()
        {
            bool isValid = true;
            if (args != null)
            {
                if (Enum.IsDefined(typeof(commandType), args[0]))
                {

                }
                else {
                    Console.WriteLine("Mode " + args[0] + " could not be found. Possible modes are:");
                    foreach (commandType mode in Enum.GetValues(typeof(commandType))) {
                        Console.Write(mode.ToString()+";");
                    }
                    isValid = false;
                }

            }
            else { 
                isValid = false;
            }
            _valid = isValid;
        }
    }
	enum commandType { full, suffix, prefix }
}
