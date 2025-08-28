using LeetCodePractice.Solutions.Medium;

namespace LeetCodePractice.Test.Solutions.Medium
{
    /// <summary>
    /// 測試資料型別
    /// </summary>
    public class InitData
    {
        public ListNode L1 { get; set; } = null!;
        public ListNode L2 { get; set; } = null!;
    }

    public class Q002_Add_Two_NumbersTests
    {
        /// <summary>
        /// 準備測試資料
        /// </summary>
        public static IEnumerable<object[]> Data => new List<object[]>
        {
            // Example 1
            new object[] { new InitData { L1 = CreateListNode(new[] { 2, 4, 3 }), L2 = CreateListNode(new[] { 5, 6, 4 }) }, CreateListNode(new[] { 7, 0, 8 }) },

            // Example 2
            new object[] { new InitData { L1 = CreateListNode(new[] { 0 }), L2 = CreateListNode(new[] { 0 }) }, CreateListNode(new[] { 0 }) },

            // Example 3
            new object[] { new InitData { L1 = CreateListNode(new[] { 9, 9, 9, 9, 9, 9, 9 }), L2 = CreateListNode(new[] { 9, 9, 9, 9 }) }, CreateListNode(new[] { 8, 9, 9, 9, 0, 0, 0, 1 }) },

            // Example 4
            new object[] { new InitData { L1 = CreateListNode(new[] { 2, 4, 9 }), L2 = CreateListNode(new[] { 5, 6, 4, 9 }) }, CreateListNode(new[] { 7, 0, 4, 0, 1 }) },
        };

        /// <summary>
        /// 從陣列建立 ListNode
        /// </summary>
        /// <param name="values">整數陣列</param>
        /// <returns>ListNode</returns>
        private static ListNode CreateListNode(int[] values)
        {
            if (values == null || values.Length == 0)
                return null!;

            var head = new ListNode(values[0]);
            var current = head;

            for (var i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void Solve(InitData input, ListNode expected)
        {
            // Arrange：準備測試物件與輸入資料
            var solution = new Q002_Add_Two_Numbers();

            // Act：執行待測方法
            var result = solution.Solve((input.L1, input.L2));

            // Assert：驗證結果
            Assert.True(AreListNodesEqual(expected, result));
        }

        /// <summary>
        /// 比較兩個 ListNode 是否相等
        /// </summary>
        /// <param name="expected">預期結果</param>
        /// <param name="actual">實際結果</param>
        /// <returns>是否相等</returns>
        private static bool AreListNodesEqual(ListNode? expected, ListNode? actual)
        {
            while (expected != null && actual != null)
            {
                if (expected.val != actual.val)
                    return false;

                expected = expected.next;
                actual = actual.next;
            }

            return expected == null && actual == null;
        }
    }
}