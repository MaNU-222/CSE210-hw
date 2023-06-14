using System;
using System.Collections.Generic;
using System.IO;

public class ListingActivity: Activity
{

 private string _message;

 private List<string> _messages = new List<string>();






public ListingActivity(string name, string description ):base(name, description)
{


}
public void SetMessage(string message){
 _message = message;
}

public string GetMessage(){

  return _message;
}

 public string GetRandomMessage()
  {

    _messages.Add("Who are people that you appreciate?");
    _messages.Add("What are personal strengths of yours?");
    _messages.Add("Who are people that you have helped this week?");
    _messages.Add("When have you felt the Holy Ghost this month?");
    _messages.Add("Who are some of your personal heroes?");








    var random = new Random();

    int index = random.Next(_messages.Count);
    return _messages[index];
  }

}