using LeetCodePractice.Core.Interface.Shared;

namespace LeetCodePractice.Solutions.Easy
{
    /// <summary>
    /// Two Sum
    /// https://leetcode.com/problems/two-sum/description/
    /// </summary>
    public class Q001_Two_Sum : ISolution<(int[] nums, int target), int[]>
    {
        public int[] Solve((int[] nums, int target) input)
        {
            var (nums, target) = input;
            var result = new int[] { };
            var dic = new Dictionary<int, int>();
            for (var idx = 0; idx < nums.Length; idx++)
            {
                var num = nums[idx];
                int prevIdx;
                if (dic.TryGetValue(target - num, out prevIdx))
                {
                    return new[] { prevIdx, idx };
                }
                if (!dic.ContainsKey(num))
                {
                    dic.Add(num, idx);
                }
            }
            return result;
        }
    }
}