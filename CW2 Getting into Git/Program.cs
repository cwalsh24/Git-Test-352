using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2_Getting_into_Git
{
    class Program
    {
        private Random r = new Random();
        //private int steve;
        private int number; 

        public void setRandom(int lower, int upper)
        {
            //Random r = new Random();
            number = r.Next(lower, upper);
        }
        public int getRandom(int n)
        {
            return number; 
        }

        static void Main(string[] args)
        {
            //variables for the user defined bounds of the guessing game
            string upper;
            string lower;
            int upperInt;
            int lowerInt;

            Console.WriteLine("Please enter the lower bound for the guessing game");
            lower = Console.ReadLine();
            Console.WriteLine("Please enter the upper bound for the guessing game");
            upper = Console.ReadLine();

            upperInt = Convert.ToInt32(upper);
            lowerInt = Convert.ToInt32(lower);

            string guess;
            int guessInt;
            int tries = 0;

            Program p = new Program();
            p.setRandom(lowerInt, upperInt); 
            Console.WriteLine("I am thinking of a number between " + lower + " and " + upper);

            Console.WriteLine("Enter your guess: ");
            guess = Console.ReadLine();
            guessInt = Convert.ToInt32(guess);
            tries = tries + 1;

            while (p.number != guessInt)
            {

                if(guessInt < p.number)
                {
                    Console.WriteLine("Too low");
                }

                if (guessInt > p.number)
                {
                    Console.WriteLine("Too high");
                }

                tries = tries + 1;
                Console.WriteLine("Enter your guess: ");
                guess = Console.ReadLine();
                guessInt = Convert.ToInt32(guess);

            }

            Console.WriteLine("Correct");
            Console.WriteLine("It took " + tries + " tries to guess the correct number.");
            Console.ReadKey();
        }
    }
}
