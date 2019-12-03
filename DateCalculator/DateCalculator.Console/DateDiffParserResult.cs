using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Console
{
    class DateDiffParserResult
    {
        public DateDiffParserResult(DateTime dateTime1, DateTime dateTime2, string operation, TimeSpan timeSpanDateTime1, TimeSpan timeSpanDateTime2,
            DateTime dateTime1Date, DateTime dateTime2Date)
        {
            DateTime1 = dateTime1;
            DateTime2 = dateTime2;
            Operation = operation;
            TimeSpanDateTime1 = timeSpanDateTime1;
            TimeSpanDateTime2 = timeSpanDateTime2;
            DateTime1Date = dateTime1Date;
            DateTime2Date = dateTime2Date;
        }

        public DateTime  DateTime1 { get; }
        public DateTime  DateTime2 { get; }
        public string Operation { get; }
        public TimeSpan TimeSpanDateTime1 { get; }
        public TimeSpan TimeSpanDateTime2 { get; }
        public DateTime DateTime1Date { get; }
        public DateTime DateTime2Date { get; }
        

    }
}
