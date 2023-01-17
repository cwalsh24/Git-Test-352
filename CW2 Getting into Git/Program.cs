/**
 * @file Program.cs
 * @author Connor Walsh
 * @date 2023-01-17
 * @brief Advanced number guessing game (git hub practice)
 * 
 * This file contains the implementation of the advanced number guessing game.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2_Getting_into_Git
{
    class Program
    {   
        //this is the randomly generated number
        private Random r = new Random();
        //this stores the randomly generated number for use in the methods
        private int number;

        /**
         * This is the set random method. This sets a random number with the user specified bounds.
         *
         * @pre The user must give the bounds
         * @post The random number has been generated
         * 
         */
        public void setRandom(int lower, int upper)
        {
            //sets the bounds for the random number
            number = r.Next(lower, upper);
        }

        /**
         * This is a getter for the random number.
         *
         * @pre The random number must be declared. 
         * @post The random number has been returned.
         * 
         */
        public int getRandom(int n)
        {
            //returns the random number
            return number; 
        }

        static void Main(string[] args)
        {
            //variables for the user defined bounds of the guessing game
            string upper;
            string lower;
            //these variables are used to store the converted input 
            int upperInt;
            int lowerInt;

            Console.WriteLine("Please enter the lower bound for the guessing game");
            lower = Console.ReadLine();
            Console.WriteLine("Please enter the upper bound for the guessing game");
            upper = Console.ReadLine();

            //converts the upper and lower bounds to an int
            upperInt = Convert.ToInt32(upper);
            lowerInt = Convert.ToInt32(lower);

            //stores the users guesses
            string guess;
            int guessInt;
            int tries = 0;

            //we need this to call the methods
            Program p = new Program();

            //calls the random method to generate a new number with the bounds
            p.setRandom(lowerInt, upperInt); 
            Console.WriteLine("I am thinking of a number between " + lower + " and " + upper);

            Console.WriteLine("Enter your guess: ");
            //gets the user's guess and converts it to an int
            guess = Console.ReadLine();
            guessInt = Convert.ToInt32(guess);
            tries = tries + 1;

            //loops until the user guesses correctly and counts the number of guesses
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
                //user is asked to input another guess.
                Console.WriteLine("Enter your guess: ");
                guess = Console.ReadLine();
                guessInt = Convert.ToInt32(guess);

            }

            //prints the number of guesses and tells the user that they guessed correctly
            Console.WriteLine("Correct");
            Console.WriteLine("It took " + tries + " tries to guess the correct number.");
            Console.ReadKey();
        }
    }
}
