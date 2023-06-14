using System;

class Program
{
  static void Main(string[] args)
  {
      int logOfBActivies = 0;
      int logOfRActivies = 0;
      int logOfLActivies = 0;
    Menu menu = new Menu();
    Activity activity = new Activity();
    BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

    ReflectingActivity reflection = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

    ListingActivity listOfActivities = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    
    while (menu.GetBegin() != "4")
    {
      
      menu.BeginProgram();
      string choice = Console.ReadLine();
      menu.SetBegin(choice);
      if (choice == "1")
        
      { ++logOfBActivies;


        Console.Clear();
        breathing.DisplayMessages(breathing.GetActivityName(), breathing.GetActivityDescription());

        string time = Console.ReadLine();
        int t = int.Parse(time);
        breathing.SetActivityDuration(t);
        breathing.GetReadyMessage();
        breathing.GetSpinner(t);
        breathing.BeginBreathingActiving(5);
        Thread.Sleep(1000);


        breathing.EndMessage(breathing.GetActivityDuration(), breathing.GetActivityName());

        Thread.Sleep(1000);
        breathing.GetSpinner(t);


      }

      if (choice == "2")
      {++logOfRActivies;
        Console.Clear();

        reflection.DisplayMessages(reflection.GetActivityName(), reflection.GetActivityDescription());
         DateTime startTime = DateTime.Now;

        string time = Console.ReadLine();
        int t = int.Parse(time);
        DateTime endTime = startTime.AddSeconds(t);
         reflection.GetReadyMessage();
        reflection.GetSpinner(t);
        reflection.SetActivityDuration(t);
        string q = reflection.GetListOfPrompts();
        reflection.SetQuestion(q);

        while (DateTime.Now < endTime)
        {

        Console.WriteLine(reflection.GetQuestion());
        Thread.Sleep(t/9);
        reflection.GetSpinner(t);
        reflection.GetReflectQuestions();

        }
       
        reflection.EndMessage(reflection.GetActivityDuration(), reflection.GetActivityName());


      }

      if (choice == "3")
      {
        ++logOfLActivies;
        Console.Clear();
        listOfActivities.DisplayMessages(listOfActivities.GetActivityName(), listOfActivities.GetActivityDescription());
        DateTime startTime = DateTime.Now;
        string time = Console.ReadLine();
        int t = int.Parse(time);
        DateTime endTime = startTime.AddSeconds(t);

        listOfActivities.GetReadyMessage();
        listOfActivities.GetSpinner(t);

        listOfActivities.SetActivityDuration(t);



        listOfActivities.SetMessage(listOfActivities.GetRandomMessage());
        string pp = listOfActivities.GetMessage();
          Console.WriteLine(pp);
          listOfActivities.GetSpinner(t);

        while (DateTime.Now < endTime)
        {

          string propmtsResponse = Console.ReadLine();
          Console.WriteLine();
        }

        listOfActivities.EndMessage(listOfActivities.GetActivityDuration(), listOfActivities.GetActivityName());




      }
    
    }
    activity.GetLogMessage(breathing.GetActivityName(), reflection.GetActivityName(), listOfActivities.GetActivityName(), logOfBActivies, logOfRActivies, logOfLActivies);

  }
}