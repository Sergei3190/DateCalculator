using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Console
{
    class DateOperationParserResult //логику не содержит - объект с данными
    {
        public DateOperationParserResult(DateTime dateTime, string sign, int number, DatePart datePart)
        {
            DateTime = dateTime;
            Sign = sign;
            Number = number;
            DatePart = datePart;
        }

        public DateTime DateTime { get;}
        public string Sign { get; }
        public int Number { get; }
        public DatePart DatePart { get; }
    }
}
