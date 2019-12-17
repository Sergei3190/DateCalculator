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
            //избавится от копипаста 16 и 19 строка 
            var dateTimeString1 = args[3];
            var dateTime1 = ParserExact(dateTimeString1);
            System.Console.WriteLine($"date time1: {dateTime1}");
           
            var dateTimeString2 = args[5];
            var dateTime2 = ParserExact(dateTimeString2);
            System.Console.WriteLine($"date time2: {dateTime2}");

            var operation = args[7];
            System.Console.WriteLine($"operation: {operation}");

            var timeSpanDateTime1 = new TimeSpan(dateTime1.Hour, dateTime1.Minute, dateTime1.Second);
            var dateTime1Date = dateTime1.Subtract(timeSpanDateTime1);

            var timeSpanDateTime2 = new TimeSpan(dateTime2.Hour, dateTime2.Minute, dateTime2.Second);
            var dateTime2Date = dateTime2.Subtract(timeSpanDateTime2);

            return new DateDiffParserResult(dateTime1, dateTime2, operation, timeSpanDateTime1, timeSpanDateTime2, dateTime1Date, dateTime2Date);
        }

        private DateTime ParserExact(string date)
        {
            var newDate =  DateTime.ParseExact(date, "yyyy-MM-ddThh:mm:ss", CultureInfo.InvariantCulture);
            return newDate;
        }
    }
}
