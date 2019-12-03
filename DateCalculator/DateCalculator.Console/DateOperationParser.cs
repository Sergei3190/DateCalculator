using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Console
{
    class DateOperationParser // содержит только логику Парсера, конвертор между уровнем доступа к данным и доменом
    {
        public DateOperationParserResult Parse(string[] args) 
        {
            var dateTimeString = args[3];
            var dateTime = DateTime.ParseExact(dateTimeString, "yyyy-MM-ddThh:mm:ss", CultureInfo.InvariantCulture);
            System.Console.WriteLine($"date time: {dateTime}");

            var operation = args[5];
            System.Console.WriteLine($"operation: {operation}");

            var sign = operation.Substring(0, 1);
            var datePartString = operation.Substring(operation.Length - 1, 1);
            var number = int.Parse(operation.Replace(sign, "").Replace(datePartString, ""));

            DatePart datePart;
            switch (datePartString)
            {
                case "Y":
                    datePart = DatePart.Year;
                    break;
                case "M":
                    datePart = DatePart.Month;
                    break;
                case "D":
                    datePart = DatePart.Day;
                    break;
                case "h":
                    datePart = DatePart.Hour;
                    break;
                case "m":
                    datePart = DatePart.Minute;
                    break;
                case "s":
                    datePart = DatePart.Second;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


            return new DateOperationParserResult(dateTime,sign,number,datePart);
        }
    }
}
