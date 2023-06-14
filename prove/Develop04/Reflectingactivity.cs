
using System;
using System.Collections.Generic;
using System.IO;

public class ReflectingActivity : Activity
{
  private string _question;
  private List<string> _questions = new List<string>();

  private List<string> _reflectQuestions = new List<string>()
  {
 " Why was this experience meaningful to you?",
    "What could you learn from this experience that applies to other situations?",
    "How can you keep this experience in mind in the future?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "Have you ever done anything like this before?",
    "What did you learn about yourself through this experience?",   
     


  };





  public ReflectingActivity(string name, string description) : base(name, description)
  {


  }

  public void SetQuestion(string question)
  {

    _question = question;
  }

  public string GetQuestion()
  {

    return _question;
  }
  public string GetListOfPrompts()
  {

    _questions.Add("Think of a time when you stood up for someone else.");
    _questions.Add("Think of a time when you did something really difficult.");
    _questions.Add("Think of a time when you helped someone in need.");
    _questions.Add(" Think of a time when you did something truly selfless.");


    var random = new Random();

    int index = random.Next(_questions.Count);
    return _questions[index];
  }

  public  void GetReflectQuestions()
  {
   foreach (var s in _reflectQuestions)
   {
    Activity act = new Activity();
    act.GetSpinner(20);
      Console.WriteLine(s);
        Thread.Sleep(4000);
    
   }
   

  }
}