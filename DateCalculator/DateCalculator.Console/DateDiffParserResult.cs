using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Console
{
    class DateDiffParserResult
    {
        public DateDiffParserResult(DateTime dateTime1, DateTime dateTime2, string operation)
        {
            DateTime1 = dateTime1;
            DateTime2 = dateTime2;
            Operation = operation;
        }

        public DateTime DateTime1 { get; }
        public DateTime DateTime2 { get; }
        public string Operation { get; }
    }
}
