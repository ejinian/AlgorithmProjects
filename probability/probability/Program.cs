using System;

namespace probability
{
    class Program
    {
        static void Main(string[] args)
        {
            Roller roller = new Roller();
            Console.WriteLine("You roll a dice 4 times in 1 experiment. You are trying to get the number 6 at least once.");
            Console.WriteLine("How many times would you want to run this experiment? The output will be the average percentage of getting 6s.");
            while (true)
            {
                float storeSixes = 0;
                int numberOfExperiments = 0;
                bool success = false;
                while (success == false)
                {
                    try
                    {
                        numberOfExperiments = int.Parse(Console.ReadLine());
                        success = true;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("please write a number");
                    }
                }

                //while (!int.TryParse(Console.ReadLine(), out numberOfExperiments))
                //{
                //    Console.WriteLine("Error");
                //}
                
                for (int i = 0; i < numberOfExperiments; i++)
                {
                    if (roller.DidGet6InNumberOfRolls(4))
                    {
                        storeSixes++;
                    }
                }
                //calculate average percent with var probablityResult
                float probabiltyResult = storeSixes / numberOfExperiments;
                //output percentage
                Console.WriteLine(probabiltyResult * 100 + "% of getting 6s in each experiment.");
                Console.WriteLine(numberOfExperiments + " number of experiments executed.");
                Console.WriteLine(numberOfExperiments * 4 + " dices rolled.");
            }
        }
    }
}
