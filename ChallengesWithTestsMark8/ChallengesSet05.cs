using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var bus in businesses)
            {
                if(bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i-1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int total = 0;
            if(numbers == null)
            {
                return 0;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0)
                {
                    total += numbers[i];
                }
            }
            return total;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
            {
                return "";
            }
            string sentence = "";

            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }

            if (sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Trim();
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return new double[0];
            }
            List<double> everyfouth = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                everyfouth.Add(elements[i]);
            }
            return everyfouth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null) 
            {
                return false;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
