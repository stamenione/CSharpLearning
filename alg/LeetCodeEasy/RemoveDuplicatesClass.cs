using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.alg.LeetCodeEasy
{
    public class RemoveDuplicatesClass
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int uniqueCount = 1;
            int currentEl = nums[0];
            for (int i = 0, j = 1; i < nums.Length; i++)
            {
                if (currentEl != nums[i])
                {
                    uniqueCount++;
                    currentEl = nums[i];
                    nums[j++] = currentEl;
                }
            }

            return uniqueCount;
        }
    }
}
