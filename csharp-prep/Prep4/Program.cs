using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0) {
            Console.Write("Enter a number (0 to quit): ");

            string UserResponse = Console.ReadLine();
            userNumber = int.Parse(UserResponse);

            if (userNumber != 0){
                numbers.Add(userNumber);
            }

        }   

        int sum = 0;
        foreach (int number in numbers) {
            sum += number;
        }

        Console.WriteLine($"The sum: {sum}");


        float average = ((float)sum) /numbers.Count;
        Console.WriteLine($"The acerage is: {average}");

        int max = numbers[0];
        foreach (int number in numbers) {
            if (number > max){
                max = number;
            }
        }



        Console.WriteLine($"The max is: {max}");



    }
}