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
                    System.Console.WriteLine(@"Date time in format ""yyyy-MM-ddThh:mm:ss"": ");
                    var d = System.Console.ReadLine();
                    System.Console.WriteLine(@"Perform an operation ""<+|-><number><date part:'Y','M','D','h','m','s'>"": ");
                    var o = System.Console.ReadLine();

                    args = new string[] { "ot", ot, "d", d, "o", o };
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
