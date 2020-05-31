using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            while(displayMenu){ 

                displayMenu= mainMenu();

            }

        }
        private static bool mainMenu()

        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Chose an Option");
            Console.WriteLine("1)Print Numbers");
            Console.WriteLine("2)Guess a Number Game");
            Console.WriteLine("3)Exit");
            String result = Console.ReadLine();

            if(result=="1")
            {
                printNumbers();
                return true;
            }
            else if(result =="2")
            {
                guessingGame();
                return true;
            }
            else if(result =="3")
            {
                return false;
            }
          else 
            {
                return true;
            }
          
        }
        private static void printNumbers()
        {
            Console.Clear();
            Console.WriteLine("Enter the number you want to print up to");
            int result  = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            int counter = 1;
            while(counter<result+1)
            {
               
                Console.Write("{0} ", counter);
                
                counter++;
            }
            Console.ReadLine();
        }

        private static void guessingGame()
        {
           
           /// Console.ReadLine();
            Console.WriteLine("Guessing Game");
           

            Random generatedRandomValue = new Random();
            int randomNo = generatedRandomValue.Next(1, 11);
            string randomNoString = randomNo.ToString();
            // int userguess = Convert.ToInt32(Console.ReadLine());
            int guessCount = 0;
            bool loopMe = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Guess a number between 1 and 10 inclusive");
                string userInput = Console.ReadLine();
                guessCount++;

                if(randomNoString == userInput)
                {
                    loopMe = false;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You have won at {0} guesses ", guessCount);
                    
                }

            } while (loopMe);
            Console.ReadLine();



        }
    }
}
