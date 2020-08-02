using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class Kata
    {
        private static Tuple<char, int> tuple(char character, int count) {
            return new Tuple<char, int>(character, count);
        }
        public static List<Tuple<char, int>> OrderedCount(string input) {
            List<Tuple<char, int>> countedChars = new List<Tuple<char, int>>();
            int counter = 0;
            char prevChar = '\\'; 
            foreach (var item in input) 
            {
                foreach (var item1 in input) 
                    if(item1 != prevChar && item1 == item)
                        counter++;
              
                if (counter != 0 && !countedChars.Contains(new Tuple<char, int>(item, counter))) 
                    countedChars.Add(tuple(item, counter)); 

                counter = 0;
                prevChar = item;
            }
          
            return countedChars;
        }
    }
}