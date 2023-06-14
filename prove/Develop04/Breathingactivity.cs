 using System;
   using System.Collections.Generic;

   public class BreathingActivity: Activity
   {
      
    



  public BreathingActivity (string name, string description ) :base(name, description){

      

  }




public void BeginBreathingActiving(int len)
{
  Console.WriteLine();

  Console.Write("Breath in...");
  
  for (int i =4; i >=0; --i){
  Console.Write(i);
  Thread.Sleep(1000);
  Console.Write("\b \b");


  }
  Console.WriteLine();

  Console.Write("Breath out...");

   for (int i =4; i >= 0; --i){
  Console.Write(i);
  Thread.Sleep(1000);
  Console.Write("\b \b");

  }
  
  Console.WriteLine();

Console.Write("Breath in...");
  
  for (int i = 6; i >= 0; --i){
  Console.Write(i);
  Thread.Sleep(1000);
  Console.Write("\b \b");

  }
  Console.WriteLine();
   Console.Write("Breath out...");

   for (int i =3; i >= 0; --i){
  Console.Write(i);
  Thread.Sleep(1000);
  Console.Write("\b \b");

  }


}


   }