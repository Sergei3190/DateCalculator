﻿using System;
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
                if (args.Length == 0)
                {
                    //запросить у пользователя - сделай сам
                }
                var operationTypeString = args[1];
                var operationType = (OperationType)Enum.Parse(typeof(OperationType), operationTypeString, true);
                System.Console.WriteLine($"operation type: {operationType:G}");

                if(operationType == OperationType.DateOperation)
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




                    #region trimeChars
                    //char[] format = {'-','+','Y','M','D','h','m','s'};
                    //var number1 = operation.Trim(format);
                    #endregion

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
