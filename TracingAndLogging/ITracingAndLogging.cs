using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.TracingAndLogging
{
    internal interface ITracingAndLogging
    {
        void WriteInfoToText(string information);
        void WriteWarningToText(string warning);
        void WriteErrorToText(string error);
    }
}
