using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("");

        //Loop//

        //this generate a random number from 1 - 100//
       Random randomGenerate = new Random();
       int magicNumber = randomGenerate.Next(1, 101);

       int guess = -1;
       String playAgain = "yes";
    
       


        while (playAgain == "yes"){
            while (guess != magicNumber)
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                

                    if (magicNumber > guess) {
                        Console.WriteLine("Higher");
                    }

                    else if(magicNumber < guess) {
                        Console.WriteLine("Lower");
                    }

                    else if(magicNumber == guess) {
                        Console.WriteLine("You guessed it");
                    }
                    
                    }
            Console.Write("Do you want to play again? ");
            Console.ReadLine(); 
                
            }

       }
               
        
    }