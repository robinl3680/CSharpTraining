using System;
using System.Collections.Generic;
using System.Text;

namespace Asignment1
{
    public class CompositeFinder
    {
        public CompositeFinder()
        {

        }
        public static string Findmatch(string word, string[] sentence)
        {
            if (Array.Exists(sentence, element => element == word))
                  return word;
            else
                return null;
        }
        public static List<string> Combination(string[] sentence)
        {
            List<string> combined = new List<string>();
            
            
            foreach(string item in sentence)
            {
                foreach(string item1 in sentence)
                {
                    string result = Findmatch(item + item1, sentence);
                    if(result != null)
                    {
                        combined.Add($"{item},{item1},{result}");
                    }
                }
            }
            return combined;
        }

       

        public static List<string> FindCompositeWordds(string sentence)
        {
            string[] words = sentence.Split(',');
            List<string> result = Combination(words);
            return result;

           
        }
    }
}
