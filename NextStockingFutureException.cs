using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOP2
{
    /// <summary>
    /// Detta är ett exception för när input är ett NextStocking datum som redan har passerat
    /// </summary>
    class NextStockingFutureException : Exception
    {
        public NextStockingFutureException(string message) : base(message) { }
    }
}
