using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    total += num;
                }
                else if (num % 2 != 0)
                {
                    total -= num;
                }
                else return 0;
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = { str1, str2, str3, str4 };
            return strings.Min(s => s.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] ints= {number1, number2, number3, number4};
            return ints.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 == 0 || sideLength2 == 0 || sideLength3 == 0)
            {
                return false;
            }
            else if(sideLength2 + sideLength3 == sideLength1)
            {
                return false;
            }
            else if (sideLength1 + sideLength2 > sideLength3)
            {
                return true;
            }
            else if (sideLength2 + sideLength3 > sideLength1)
            {
                return false;
            }
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out var number);
            if (isNumber == true)
            {
                return true;
            }
            else
                return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCounter = 0;
            var majority = .5 * objs.Length;
            foreach (object obj in objs)
            {
                if(obj == null)
                {
                    nullCounter++;
                }
            }
            if (nullCounter > majority)
            {
                return true;
            }
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double evensCounter = 0;

            if(numbers == null)
            {
                return 0;
            }

            foreach (var num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                    evensCounter++;
                }
            }

            if (evensCounter > 0)
            {
                return sum / evensCounter;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            var fact = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
