using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using DirectInput;

namespace KeyPressTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                DirectInput.DirectInput.SendKeyPress(args[0]);
            }
        }
    }
}
