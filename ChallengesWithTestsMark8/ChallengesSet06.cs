using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //throw new NotImplementedException();

            if(words.Contains(word)) 
                return true;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) 
                return false;

            if (num == 2) 
                return true;

            if (num % 2 == 0) 
                return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
                if (num % i == 0)
                    return false;

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
            //int indexCounter = 0;
            //s
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
