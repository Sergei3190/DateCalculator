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
                dateTimeNew = result.DateTime1.AddYears(result.DateTime2.Year)
                                              .AddMonths(result.DateTime2.Month)
                                              .AddDays(result.DateTime2.Day)
                                              .AddHours(result.DateTime2.Hour)
                                              .AddMinutes(result.DateTime2.Minute)
                                              .AddSeconds(result.DateTime2.Second);
            }
            else if (result.Operation == "-")
            {
                dateTimeNew = result.DateTime1.AddYears(result.DateTime2.Year * (-1))
                                              .AddMonths(result.DateTime2.Month * (-1))
                                              .AddDays(result.DateTime2.Day * (-1))
                                              .AddHours(result.DateTime2.Hour * (-1))
                                              .AddMinutes(result.DateTime2.Minute * (-1))
                                              .AddSeconds(result.DateTime2.Second * (-1));
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
