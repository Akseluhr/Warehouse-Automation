using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOP2
{
    /// <summary>
    /// Detta är ett exception för när ett tomt värde skickas in
    /// </summary>
    class EmptyValueException : Exception
    {
        public EmptyValueException(string message) : base(message)
        {

        }
    }
}
