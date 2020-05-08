using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Console
{
    class DateOperationCalculator //содержит только доменную логику(расчет)
    {
        public DateTime Calculate(DateOperationParserResult dateOperationParserResult)
        {
            var number = dateOperationParserResult.Number;
            DateTime dateTimeNew;

            if (dateOperationParserResult.Sign == "+") 
            {

            }
            else if (dateOperationParserResult.Sign == "-")
            {
                number *= -1;
            }

            switch (dateOperationParserResult.DatePart)
            {
                case DatePart.Year:
                    dateTimeNew = dateOperationParserResult.DateTime.AddYears(number);
                    break;
                case DatePart.Month:
                    dateTimeNew = dateOperationParserResult.DateTime.AddMonths(number);
                    break;
                case DatePart.Day:
                    dateTimeNew = dateOperationParserResult.DateTime.AddDays(number);
                    break;
                case DatePart.Hour:
                    dateTimeNew = dateOperationParserResult.DateTime.AddHours(number);
                    break;
                case DatePart.Minute:
                    dateTimeNew = dateOperationParserResult.DateTime.AddMinutes(number);
                    break;
                case DatePart.Second:
                    dateTimeNew = dateOperationParserResult.DateTime.AddMinutes(number);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return dateTimeNew;
        }
    }
}
