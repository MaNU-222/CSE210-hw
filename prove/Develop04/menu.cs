using System;
using System.Collections.Generic;

public class Menu
{
  
  private string _begin = "";









public string GetBegin()
{
   
   return _begin;
}

public void SetBegin(string begin){

  _begin = begin;
}


  public void BeginProgram()
  {
    Console.WriteLine("New Options:");
    Console.WriteLine("1. Start breathing Activity");
    Console.WriteLine("2. Start reflecting Activity");
    Console.WriteLine("3. Start listing Activity");
    Console.WriteLine("4. Quit");
    Console.WriteLine("Select a choice from the menu");

  }


}