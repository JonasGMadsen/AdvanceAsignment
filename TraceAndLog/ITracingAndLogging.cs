using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.TraceAndLog
{
    internal interface ITracingAndLogging
    {
        void TraceMethodEntry(string methodName, string parameters);
        void TraceMethodExit(string methodName, string returnValue);
        void WriteInfoToText(string information);
        void WriteErrorToText(string error);
    }
}
