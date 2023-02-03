using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number% 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
                return 0;

            if (numbers.Any())
            {
                return numbers.Min() + numbers.Max();
            }
            else
                return 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1 == "" || str2 == "")
            {
                return 0;
            }
            else if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
                return str2.Length;

        }

        public int Sum(int[] numbers)
        {
            int total = 0;
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            foreach(var number in numbers)
            {
                total += number;
            }
            return total;
        }

        public int SumEvens(int[] numbers)
        {
            int total = 0;
            if(numbers != null)
            {
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        total += num;
                    }
                }
            }
            return total;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int total = 0;
            if (numbers == null)
                return false;

            foreach (var num in numbers)
            {
                total += num;
            }

            if (total % 2 != 0)
                return true;
            else
                return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //throw new NotImplementedException();
            int counter = 0;
            while (number > 0)
            {
                number -= 1;
                if(number % 2 != 0)
                    counter++;
            }
            return counter;
        }
    }
}
