using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("");  /*This is just creating a space for a new line*/

        /*The prep start from here*/
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? "); /*this print the question out*/
        string last = Console.ReadLine();           /*this receives the input*/

        Console.WriteLine($"Your name is {last}, {first} {last}."); /*this is just like f string in python*/
        
    }
}