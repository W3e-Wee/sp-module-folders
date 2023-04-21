using System;

namespace ExperimentRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call CountDown method
            // At the same time enter a value of 5
            CountDown(5);
        }// End of Main

        static void CountDown(int num)
        {
            Console.WriteLine(num);
            // When Base cases condition met
            // stop the recursive call
            if (num <= 1)
            {   // Base case
                return; // return statement
            }
            else
            {   // Recursive case
                // Call CoundDown again
                // Reduce number by 1
                CountDown(num - 1);
            }
        }// End of CountDown method
    }// End of Program class
}// End of namespace
