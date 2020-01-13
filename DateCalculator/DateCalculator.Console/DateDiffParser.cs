using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Console
{
    class DateDiffParser
    {
        public DateDiffParserResult Parser(string[] args)
        {
            var dateTimeString1 = args[3];
            var dateTime1 = ParserExact(dateTimeString1);
            System.Console.WriteLine($"date time1: {dateTime1}");
           
            var dateTimeString2 = args[5];
            var dateTime2 = ParserExact(dateTimeString2);
            System.Console.WriteLine($"date time2: {dateTime2}");

            var operation = args[7];
            System.Console.WriteLine($"operation: {operation}");          

            return new DateDiffParserResult(dateTime1, dateTime2, operation);
        }

        private DateTime ParserExact(string date)
        {
            var newDate =  DateTime.ParseExact(date, "yyyy-MM-ddThh:mm:ss", CultureInfo.InvariantCulture);
            return newDate;
        }
    }
}
