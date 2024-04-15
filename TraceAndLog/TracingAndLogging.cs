using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAsignment.TraceAndLog
{
    public class TracingAndLogging : ITracingAndLogging
    {
        private TraceSource traceSource = new TraceSource("AdvanceAsignment"); //TODO. Try and implment bruh
        private TextWriterTraceListener textWriter;

        private static TracingAndLogging instance;

        public static TracingAndLogging Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TracingAndLogging();
                }
                return instance;
            }
        }

        private TracingAndLogging()
        {
            traceSource.Switch = new SourceSwitch("TracingAndLogging", "All");
            textWriter = new TextWriterTraceListener(new StreamWriter("log.txt") { AutoFlush = true });
            traceSource.Listeners.Add(textWriter);
        }

        public void TraceMethodEntry(string methodName, string parameters)
        {
            traceSource.TraceEvent(TraceEventType.Verbose, 0, $"Entering {methodName}. Parameters: {parameters}");
        }

        public void TraceMethodExit(string methodName, string returnValue)
        {
            traceSource.TraceEvent(TraceEventType.Verbose, 0, $"Exiting {methodName}. Return Value: {returnValue}");
        }

        public void WriteErrorToText(string error)
        {
            traceSource.TraceEvent(TraceEventType.Error, 300, error);
        }

        public void WriteInfoToText(string writeToTxt)
        {
            traceSource.TraceEvent(TraceEventType.Information, 200, writeToTxt);
        }

        public void WriteWarningToText(string warning)
        {
            traceSource.TraceEvent(TraceEventType.Warning, 100, warning);
        }

        public void Flush()
        {
            traceSource.Flush();
        }

    }
}
