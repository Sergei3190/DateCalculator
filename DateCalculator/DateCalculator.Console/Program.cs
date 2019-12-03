using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.OutputEncoding = Encoding.Unicode;
               
                if (args.Length == 0)
                {                    
                    System.Console.WriteLine("Please enter data: ");
                    System.Console.WriteLine(@"Operation type ""DateOperation|DateDiff"": ");
                    var ot = System.Console.ReadLine();                

                    //здесь дописать ввод аргументов в зависимости от выбранной операции
                    if (ot == "DateOperation")
                    {
                        System.Console.WriteLine(@"Date time in format ""yyyy-MM-ddThh:mm:ss"": ");
                        var d = System.Console.ReadLine();
                        System.Console.WriteLine(@"Perform an operation ""<+|-><number><date part:'Y','M','D','h','m','s'>"": ");
                        var o = System.Console.ReadLine();
                        args = new string[] { "ot", ot, "d", d, "o", o };
                    }
                    else if (ot == "DateDiff")
                    {
                        System.Console.WriteLine(@"First date time in format ""yyyy-MM-ddThh:mm:ss"": ");
                        var d1 = System.Console.ReadLine();
                        System.Console.WriteLine(@"Second date time in format ""yyyy-MM-ddThh:mm:ss"": ");
                        var d2 = System.Console.ReadLine();
                        System.Console.WriteLine(@"Perform an operation ""<+|->"": ");
                        var o = System.Console.ReadLine();
                        args = new string[] {"ot", ot, "d1", d1, "d2", d2, "o", o };
                    }
                   
                }
                var operationTypeString = args[1];
                var operationType = (OperationType)Enum.Parse(typeof(OperationType), operationTypeString, true);
                System.Console.WriteLine($"operation type: {operationType:G}");

                if(operationType == OperationType.DateOperation)
                {
                    var parser = new DateOperationParser();
                    var calculator = new DateOperationCalculator();
                    var parseResult = parser.Parse(args);
                    var dateTimeNew = calculator.Calculate(parseResult);
                    System.Console.WriteLine($"Result {dateTimeNew}");

                    #region trimeChars
                    //char[] format = {'-','+','Y','M','D','h','m','s'};
                    //var number1 = operation.Trim(format);
                    #endregion
                }
                else if (operationType == OperationType.DateDiff)
                {                   
                    var dateTimeString1 = args[3];
                    var dateTime1 = DateTime.ParseExact(dateTimeString1, "yyyy-MM-ddThh:mm:ss", CultureInfo.InvariantCulture);

                    var dateTimeString2 = args[5];
                    var dateTime2 = DateTime.ParseExact(dateTimeString2, "yyyy-MM-ddThh:mm:ss", CultureInfo.InvariantCulture);

                    var operation = args[7];
                    System.Console.WriteLine($"operation: {operation}");

                    var timeSpanDateTime1 = new TimeSpan(dateTime1.Hour, dateTime1.Minute, dateTime1.Second);
                    var dateTime1Date = dateTime1.Subtract(timeSpanDateTime1);

                    var timeSpanDateTime2 = new TimeSpan(dateTime2.Hour, dateTime2.Minute, dateTime2.Second);
                    var dateTime2Date = dateTime2.Subtract(timeSpanDateTime2);

                    DateTime dateTimeNew = new DateTime();

                    if (operation == "+")
                    {
                        var timeSpanNew = timeSpanDateTime1 + timeSpanDateTime2;
                        var dateTimeNewDate = dateTime1Date.AddYears(dateTime2Date.Year).AddMonths(dateTime2Date.Month).AddDays(dateTime2Date.Day);
                        dateTimeNew = dateTimeNewDate.Add(timeSpanNew);                      
                    }
                    else if (operation == "-")
                    {
                        var timeSpanNew = timeSpanDateTime1 - timeSpanDateTime2;
                        var number = (dateTime2Date.Year, dateTime2Date.Month, dateTime2Date.Day);
                        number.Year *= -1;
                        number.Month *= -1;
                        number.Day *= -1;
                        var dateTimeNewDate = dateTime1Date.AddYears(number.Year).AddMonths(number.Month).AddDays(number.Day);
                        dateTimeNew = dateTimeNewDate.Add(timeSpanNew);
                    }

                    var dateDiff = dateTime1.Subtract(dateTime2);

                    System.Console.WriteLine($"Result: {dateTimeNew}, dateDiff = {dateDiff}");

                }

            } 
            catch(Exception ex)
            {
                System.Console.WriteLine(ex);
            }
            finally
            {
                System.Console.ReadLine();
            }
           

        }
    }
}
