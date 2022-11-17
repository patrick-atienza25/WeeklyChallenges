using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals.Contains(false))
            {
                return true;
            }
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
            {
                return true;
            }
            else
                return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();
            if(password.Contains('')
        }

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(dividend == 0 || divisor == 0)
            {
                return 0;
            }
            else
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
