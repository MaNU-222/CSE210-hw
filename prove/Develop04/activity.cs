using System;
using System.Collections.Generic;

public class Activity
{
private string _name = "";
private string _description = "";
private int _activityduration;





public Activity(){}
public Activity(string name, string description){
  _name = name;
  _description = description;
}

public  Activity(string name, string description, int duration)
{

_name = name;
_description= description;
_activityduration = duration;


}
public void SetActivityName(string name ){

  _name = name;
}
public string GetActivityName(){

  return _name;
}

public void SetActivityDescription(string description ){

  _description = description;
}
public string GetActivityDescription(){

  return _description;
}
public void SetActivityDuration(int duration ){

  _activityduration = duration;
}
public int GetActivityDuration(){

  return _activityduration;
}


public void GetReadyMessage(){

  Console.WriteLine("Get Ready...");
}
public void GetSpinner(int time)
{
   List <string> animation = new List<string>();

   animation.Add("|");
   animation.Add("/");
   animation.Add("-");
   animation.Add("\\");
   animation.Add("|");
   animation.Add("/");
   animation.Add("|");
   animation.Add("-");
   animation.Add("\\");
   

         Console.WriteLine();
   


  DateTime startTime = DateTime.Now;
  DateTime endTime = startTime.AddSeconds(time/ 9);

  int i = 0;
  while (DateTime.Now < endTime)
  {
     string s = animation[i];
     Console.Write(s);
     Thread.Sleep(1000);
     Console.Write("\b \b");

     ++i;

     if (i >= animation.Count)
     {
      i = 0;
     }

  }
   

 
   

}

public void DisplayMessages(string name, string description)
{  


   Console.WriteLine($"Welcome to the {name} Activity");
   Console.WriteLine();
   Console.WriteLine(description);
  

   Console.WriteLine();
   Console.Write("How long, in seconds, would you like for your session?");
}
public void EndMessage(int time, string name ){

  Console.WriteLine("Well Done!!");
  Thread.Sleep(1000);
  Console.WriteLine($"You have completed another {time} seconds of the {name}");
}

public void GetLogMessage(string name1,string name2, string name3, int number1, int number2, int number3)
{

   Console.WriteLine($"You have completed {number1} {name1} Activity(ies)");
    Console.WriteLine($"You have completed {number2} {name2} Breathing Activity(ies)");
    Console.WriteLine($"You have completed {number3} {name3} Breathing Activity(ies)");
}


}