using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.alg.LeetCodeEasy
{
    public class TwoSumClass
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {   
                int c = target - nums[i];
                if (result.ContainsKey(c)) // Ovo je zapravo provera da li komplement vec postoji kao kljuc
                {
                    return new int[] { result[c], i };
                }
                if (!result.ContainsKey(nums[i]))
                {
                    result.Add(nums[i], i);
                }
            }
            return new int[2];
        }
    }
}