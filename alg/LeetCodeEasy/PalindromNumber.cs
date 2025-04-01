using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.alg.LeetCodeEasy
{
    public class PalindromNumber
    {

        public static bool IsPalindrome(int x)
        {
            int r = 0, c = x;

            while (c > 0)
            {
                r = r * 10 + c % 10;
                c = c / 10;
            }

            return r == x;
        }
        public static bool IsPalindrome1(int x)
        {
            if (x < 0) return false;

            ArrayList numbers = new ArrayList();
            int dividingNumber = 10;
            bool isPalindrome = true;

            for (int i = 0; x > 0; i++)
            {
                int remainder = x % dividingNumber;
                numbers.Add(remainder);
                x = x / 10;
            }

            for (int i = 0, j = numbers.Count - 1; j >= 0; i++, j--)
            {
                if (!numbers[i].Equals(numbers[j])) isPalindrome = false;
            }

            return isPalindrome;
        }
    }
}
