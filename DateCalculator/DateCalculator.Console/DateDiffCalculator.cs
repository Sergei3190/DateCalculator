using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Console
{
    class DateDiffCalculator
    {
        public DateTime CalculateNewDate(DateDiffParserResult result)
        {
            DateTime dateTimeNew = new DateTime();
            if (result.Operation == "+")
            {
                var timeSpanNew = result.TimeSpanDateTime1 + result.TimeSpanDateTime2;
                var dateTimeNewDate = result.DateTime1Date.AddYears(result.DateTime2Date.Year).AddMonths(result.DateTime2Date.Month).AddDays(result.DateTime2Date.Day);
                dateTimeNew = dateTimeNewDate.Add(timeSpanNew);
            }
            else if (result.Operation == "-")
            {
                var timeSpanNew = result.TimeSpanDateTime1 - result.TimeSpanDateTime2;
                var number = (result.DateTime2Date.Year, result.DateTime2Date.Month, result.DateTime2Date.Day);
                number.Year *= -1;
                number.Month *= -1;
                number.Day *= -1;
                var dateTimeNewDate = result.DateTime1Date.AddYears(number.Year).AddMonths(number.Month).AddDays(number.Day);
                dateTimeNew = dateTimeNewDate.Add(timeSpanNew);
            }

            return dateTimeNew;
        }

        public TimeSpan CalculateDateDiff(DateDiffParserResult dateDiffParser)
        {
            var dateDiff = dateDiffParser.DateTime1.Subtract(dateDiffParser.DateTime2);
            return dateDiff;
        }
    }
}
