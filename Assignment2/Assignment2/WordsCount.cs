using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class WordsCount
    {
        public static SortedList<string,int> CountWords(string sentence)
        {
            int index = 0;
            sentence = sentence.ToLower();
            char[] delimeters = new char[sentence.Length];
            for(int i = 0; i < sentence.Length; i++)
            {
                if (!char.IsLetterOrDigit(sentence[i]) && sentence[i] != '@')
                    delimeters[index++] = sentence[i];
            }

            string[] words = sentence.Split(delimeters,StringSplitOptions.RemoveEmptyEntries);
            SortedList<string, int> wordsDictionary = new SortedList<string, int>();
            foreach(string items in words)
            {
                if (wordsDictionary.ContainsKey(items))
                    wordsDictionary[items]++;
                else
                    wordsDictionary[items] = 1;
            }
            return wordsDictionary;
        }
   }
}
