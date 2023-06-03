using System;

class Program
{
  static void Main(string[] args)
  {

 Scripture scripture = new Scripture("1 Nephi 2","Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians.");


        scripture.Display();

        Console.WriteLine("Would you like to save the scripture for future purpose?");
      string    save = Console.ReadLine();

      if (save == "yes"){
        Console.WriteLine("what is the file path name");
        string saved = Console.ReadLine();

        scripture.ScriptureToFile(saved);
      }

      else{

        while(!scripture.AllWordsHidden){

            Console.Clear();    
            scripture.Display();
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            
            string input = Console.ReadLine();

            if (input.ToLower() == "quit"){
                break;
            }
            else{
                scripture.HideRandomWord();
            }
        }}

        Console.Clear();
        scripture.DisplayHidden();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
  }


}