using System;
using System.Collections.Generic;
using System.IO;


public class Reference
{
  
    public string _text {get;}

    public Reference(string text){

        _text = text; 
    }

    public void Display(){

        Console.WriteLine(_text);
    }
}
