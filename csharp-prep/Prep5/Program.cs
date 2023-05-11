using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayMessaage();

        string username = PromptUserName();
        int usernumber = PromptUserNumber();

        int squarednumber = Squarednumber(usernumber);

        DisplayResult(username, squarednumber);
    }

    static void DisplayMessaage(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("Pease enteryour name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favourite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int Squarednumber(int number){
        int square = number * number;
        return square;
    }


    static void DisplayResult(string name, int square){
        Console.WriteLine($"{name}, the square of your number is {square}");
    }















    
}