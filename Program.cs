using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();
            char[] separators = {' ',',','.',':',';',}; //Can be expanded
            string[] words = text.Split(separators); //Leaves "" between separators
            Dictionary<string, int> matches = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if(!matches.ContainsKey(word))
                {
                    matches.Add(word, 1);
                }
                else
                {
                    matches[word]++;
                }
            }
            foreach (string word in matches.Keys)
            {
                if(word != "")
                {
                    Console.WriteLine("Word: {0}\toccurs in this text {1} times", word, matches[word]);
                }
            }
            Console.ReadLine();
        }
    }
}
//hello,hello bye, bye; hello