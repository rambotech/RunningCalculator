using System;

namespace RunningCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running calculator.  Enter an amount, ENTER to reset total, ENTER twice to end.");
            double total = 0.0;
            double amount = -1.0;
            var done = false;
            while (!done)
            {
                var accepted = false;
                while (! accepted)
                {
                    Console.Write(string.Format("{0,20:$#,##0.00;($#,##0.00);Zero} --> ", total));
                    amount = 0.0;
                    var addend = Console.ReadLine();
                    if (string.IsNullOrEmpty(addend))
                    {
                        accepted = true;
                        if (total == 0.0)
                        {
                            done = true;
                            continue;
                        }
                        total = 0.0;
                        Console.WriteLine();
                        continue;
                    }
                    accepted = double.TryParse(addend, out amount);
                    if (accepted) continue;
                    Console.WriteLine ("Invalid input");
                }
                total += amount;
            }
        }
    }
}
