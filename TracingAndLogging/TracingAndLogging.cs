using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.TracingAndLogging
{
    public class TracingAndLogging : ITracingAndLogging
    {
        private TraceSource traceSource = new TraceSource("AdvanceAsignment");
        private TextWriterTraceListener textWriter;

        private static readonly Lazy<TracingAndLogging> instance = new Lazy<TracingAndLogging>(() => new TracingAndLogging()); //Lazy initialization. For a sikre thread safety. Experimentielt. 

        public static TracingAndLogging Instance
        {
            get
            {
                return instance.Value;
            }
        }

        private TracingAndLogging()
        {
            traceSource.Switch = new SourceSwitch("TracingAndLogging", "All");
            textWriter = new TextWriterTraceListener(new StreamWriter("log.txt") { AutoFlush = true });
            traceSource.Listeners.Add(textWriter);
        }

        public void WriteErrorToText(string error)
        {
            throw new NotImplementedException();
        }

        public void WriteInfoToText(string writeToTxt)
        {
            traceSource.TraceEvent(TraceEventType.Information, 200, writeToTxt);
        }

        public void WriteWarningToText(string warning)
        {
            traceSource.TraceEvent(TraceEventType.Warning, 100, warning);
        }

    }
}
