using LeetCodePractice.Solutions.Medium;
using Xunit;

namespace LeetCodePractice.Test.Solutions.Medium
{
    public class Q003_Longest_Substring_Without_Repeating_CharactersTests
    {
        /// <summary>
        /// 準備測試資料
        /// </summary>
        public static IEnumerable<object[]> Data => new List<object[]>
        {
            // Example 1: Input: s = "abcabcbb", Output: 3
            // Explanation: The answer is "abc", with the length of 3.
            new object[] { "abcabcbb", 3 },
            
            // Example 2: Input: s = "bbbbb", Output: 1
            // Explanation: The answer is "b", with the length of 1.
            new object[] { "bbbbb", 1 },
            
            // Example 3: Input: s = "pwwkew", Output: 3
            // Explanation: The answer is "wke", with the length of 3.
            new object[] { "pwwkew", 3 },
            
            // Edge case: Empty string
            new object[] { "", 0 },
            
            // Edge case: Single character
            new object[] { "a", 1 }
        };

        [Theory]
        [MemberData(nameof(Data))]
        public void Solve(string input, int expected)
        {
            // Arrange：準備測試物件與輸入資料
            var solution = new Q003_Longest_Substring_Without_Repeating_Characters();

            // Act：執行待測方法
            var result = solution.Solve(input);

            // Assert：驗證結果
            Assert.Equal(expected, result);
        }
    }
}