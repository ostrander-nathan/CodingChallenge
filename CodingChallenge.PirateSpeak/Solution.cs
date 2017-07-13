using System;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
        

            var orderedLetters = jumble.OrderBy(y => y);
            var compareWords = dictionary.OrderBy(x => x);

            //foreach (var word in dictionary)
            //{
            //     word.OrderBy(x=>x).Where(orderedLetters == compareWords)   
            //}
          

            return null;

        }
    }
}