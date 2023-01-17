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

        public void setRandom()
        {
            //Random r = new Random();
            number = r.Next(0, 100);
        }
        public int getRandom(int n)
        {
            return number; 
        }

        static void Main(string[] args)
        {
            string guess;
            int guessInt;
            int tries = 0;
            Console.WriteLine("hello world ");
            Program p = new Program();
            p.setRandom(); 
            Console.WriteLine("I am thinking of a number between 1 and 100");

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
