using LeetCodePractice.Solutions.Easy;

namespace LeetCodePractice.Test.Solutions.Easy
{
    /// <summary>
    /// 測試資料型別
    /// </summary>
    public class InitData
    {
        public int[] Nums { get; set; } = [];
        public int Target { get; set; }
    }

    public class Q001_Two_SumTests
    {
        /// <summary>
        /// 準備測試資料
        /// </summary>
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { new InitData { Nums = new[] { 2, 7, 11, 15 }, Target = 9 }, new[] { 0, 1 } },
                new object[] { new InitData { Nums = new[] { 3, 2, 4 }, Target = 6 }, new[] { 1, 2 } },
                new object[] { new InitData { Nums = new[] { 3, 3 }, Target = 6 }, new[] { 0, 1 } },
                new object[] { new InitData { Nums = new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, Target = 11 }, new[] { 5, 11 } }
            };

        [Theory]
        [MemberData(nameof(Data))]
        public void Solve(InitData input, int[] expected)
        {
            // Arrange：準備測試物件與輸入資料
            var solution = new Q001_Two_Sum();

            // Act：執行待測方法
            var result = solution.Solve((input.Nums, input.Target));

            // Assert：驗證結果
            Assert.Equal(expected, result);
        }
    }
}