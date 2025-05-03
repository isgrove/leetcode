namespace LeetCode.Arrays
{
    public class TwoSum
    {
        // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //
        // You can return the answer in any order.
        public static int[] Run(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            int curr;

            for (var i = 0; i < nums.Length; i++)
            {
                curr = nums[i];

                if (dict.TryGetValue(curr, out var j))
                    return [j, i];

                dict[target - curr] = i;
            }

            return [];
        }

        [Fact]
        public void TwoSumExample1()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new int[] { 0, 1 };
            var result = Run(nums, target);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TwoSumExample2()
        {
            var nums = new int[] { 3, 2, 4 };
            var target = 6;
            var expected = new int[] { 1, 2 };
            var result = Run(nums, target);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TwoSumExample3()
        {
            var nums = new int[] { 3, 3 };
            var target = 6;
            var expected = new int[] { 0, 1 };
            var result = Run(nums, target);

            Assert.Equal(expected, result);
        }
    }
}