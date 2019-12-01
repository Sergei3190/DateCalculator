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
                if (args.Length == 0)
                {
                    //запросить у пользователя - сделай сам
                }
                var operationTypeString = args[1];
                var operationType = (OperationType)Enum.Parse(typeof(OperationType), operationTypeString, true);
                System.Console.WriteLine($"operation type: {operationType:G}");

                if(operationType == OperationType.DateOperation)
                {
                    var calculator = new DateOperationCalculator();
                    var dateTimeNew = calculator.Calculate(args);
                    System.Console.WriteLine($"Result {dateTimeNew}");

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
