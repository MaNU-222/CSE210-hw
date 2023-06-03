using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{ 
    private Reference _reference;
    private List<Word> _words; 
    private List<Word> _hiddenWords;

    public bool AllWordsHidden{
        get{
            return _hiddenWords.Count == _words.Count;
        }
    }

    public Scripture(string textReference, string textScripture){

        _reference = new Reference(textReference);
        _words = SplitWords(textScripture);
        _hiddenWords = new List<Word>();
    }
    
    
    public void Display(){
        _reference.Display();
        foreach(Word word in _words){
            if (_hiddenWords.Contains(word)){
                Console.Write("___ ");
            }
            else{
                Console.Write(word._text + " ");
            }
        }
        Console.WriteLine();
    }
}