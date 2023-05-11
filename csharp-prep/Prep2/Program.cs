using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("");




        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);  

        if (number >= 97)
        {
            Console.WriteLine("grade: A+");
            Console.WriteLine("GPA: 4.0");
            Console.WriteLine("SUPERB!!!");
        }

        else if (number >= 93)
        {
            Console.WriteLine("Grade: A");
            Console.WriteLine("GPA: 4.0");
            Console.WriteLine("EXCELLENT!!!");
        }

        else if (number >= 90)
        {
            Console.WriteLine("Grade: A-");
            Console.WriteLine("GPA: 3.7");
            Console.WriteLine("SATISFACTORY!!!");
        }

        else if (number >= 87)
        {
            Console.WriteLine("Grade: B+");
            Console.WriteLine("GPA: 3.3");
            Console.WriteLine("SATISFCTORY!!");
        }

        else if (number >= 83)
        {
            Console.WriteLine("Grade: B");
            Console.WriteLine("GPA: 3");
            Console.WriteLine("GOOD!!!");
        }
        
        else if (number >= 80)
        {
            Console.WriteLine("Grade: B-");
            Console.WriteLine("GPA: 2.7");
            Console.WriteLine("GOOD!!!");
        }

        else if (number >= 77)
        {
            Console.WriteLine("Grade: C+");
            Console.WriteLine("GPA: 2.3");
            Console.WriteLine("PASS!!!");
        }
        
        else if (number >= 73)
        {
            Console.WriteLine("Grade: C");
            Console.WriteLine("GPA: 2");
            Console.WriteLine("PASS!!!");
        }

        else if (number >= 70)
        {
            Console.WriteLine("Grade: C-");
            Console.WriteLine("GPA: 1.7");
            Console.WriteLine("PASSING!!!");
        }

         else if (number >= 67)
        {
            Console.WriteLine("Grade: D+");
            Console.WriteLine("GPA: 1.3");
            Console.WriteLine("PASSING!!!");
        }

         else if (number >= 65)
        {
            Console.WriteLine("Grade: D");
            Console.WriteLine("GPA: 1");
            Console.WriteLine("PASSING!!!");
        }
        
        else
        {
            Console.WriteLine("Grade: F");
            Console.WriteLine("GPA: 0");
            Console.WriteLine("FAIL!!!");
        }
    }
}