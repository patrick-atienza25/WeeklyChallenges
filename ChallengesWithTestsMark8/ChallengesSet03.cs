using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals.Contains(false))
                return true;
            else
                return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var odds = new List<int>();
            if(numbers != null)
            {
                foreach (var num in numbers)
                {
                    if (num % 2 != 0)
                    {
                        odds.Add(num);
                    }
                }
            
            }
            if (odds.Sum() % 2 != 0)
                return true;
            else
                return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
                return true;
            else
                return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(dividend == 0 || divisor == 0)
                return 0;
            else
                return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var oddsList = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if(i % 2 != 0)
                {
                    oddsList.Add(i);
                }
            }
            return oddsList.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
