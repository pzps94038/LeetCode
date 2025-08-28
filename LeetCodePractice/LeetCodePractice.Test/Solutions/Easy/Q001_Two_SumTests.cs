using LeetCodePractice.Solutions.Easy;
using Xunit;

namespace LeetCodePractice.Test.Solutions.Easy
{
    /// <summary>
    /// ���ո�ƫ��O
    /// </summary>
    public class InitData
    {
        public int[] Nums { get; set; } = [];
        public int Target { get; set; }
    }

    public class Q001_Two_SumTests
    {
        /// <summary>
        /// �ǳƴ��ո��
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
            // Arrange�G�ǳƴ��ժ���P��J���
            var solution = new Q001_Two_Sum();

            // Act�G����ݴ���k
            var result = solution.Solve((input.Nums, input.Target));

            // Assert�G���ҵ��G
            Assert.Equal(expected, result);
        }
    }
}