namespace AsyncAndAwait
{
    class Program
    {
        /// <summary>
        /// Change the code so that you will see "Congratulation. Your application is fast enough!!!" message.
        /// Your application should not return "Sorry longRunningMethodReturnValues does not..." message.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static async Task Main(string[] args)
        {
            var startTime = DateTime.Now;

            var longRunningMethodReturnValues = string.Empty;

            longRunningMethodReturnValues += await LongRunningMethod("abc");
            longRunningMethodReturnValues += await LongRunningMethod("def");
            longRunningMethodReturnValues += await LongRunningMethod("ghi");

            // DON'T EDIT CODE BELOW THIS COMMENT.
            if(!longRunningMethodReturnValues.Contains("abc") && 
                !longRunningMethodReturnValues.Contains("def") && 
                !longRunningMethodReturnValues.Contains("ghi"))
            {
                Console.WriteLine("Sorry longRunningMethodReturnValues does not contain all the required strings. Your application does not wait all threads.");
            }

            if(DateTime.Now.Subtract(startTime).TotalMilliseconds < 2200)
            {
                Console.WriteLine("Congratulation. Your application is fast enough now!!!");
            }
            else
            {
                Console.WriteLine("Sorry your application is still too slow");
            }
            Console.WriteLine("");
            Console.WriteLine($"Application executiong took {DateTime.Now.Subtract(startTime).TotalMilliseconds} ms. Application should take less than 2200ms to execute.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to stop application.");

            Console.ReadKey();
        }

        private static async Task<string> LongRunningMethod(string returnString)
        {
            Console.WriteLine(returnString);
            await Task.Delay(2000);
            return returnString;
        }
    }

    public class Person
    {
        public string FormatAddress(string address)
        {
            if(address is null)
            {
                throw new ArgumentNullException(nameof(address));
            }

            return address.ToUpper();
        }

        public string FormatAddress2(string address) => address is null ? throw new ArgumentNullException(nameof(address)) : address;
    }
}