using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOP2
{
    /// <summary>
    /// Detta är ett exception för när input är mindre än noll
    /// </summary>
    class LessThanZeroException : Exception
    {
        public LessThanZeroException(string message) : base(message) { }
    }
}
