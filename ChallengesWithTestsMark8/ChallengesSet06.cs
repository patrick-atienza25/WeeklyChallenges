using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            return (ignoreCase) ? words?.Select(x => x?.ToLower()).Contains(word) ?? false : words?.Contains(word) ?? false;
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
            int index = -1;

            bool uniqueIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;

                for (int k = 0; k < str.Length; k++)
                {
                    if (str[i] == str[k] && i != k)
                    {
                        uniqueIndex = false;
                    }
                }

                if(uniqueIndex == true)
                {
                    index = i;
                }
            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if(currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> elementList = new List<double>();

            if(elements == null || n <= 0 || n > elements.Count)
            {
                return elementList.ToArray();
            }

            for (int i = n - 1; i < elements.Count; i+=n)
            {
                elementList.Add(elements[i]);
            }

            return elementList.ToArray();
        }
    }
}
