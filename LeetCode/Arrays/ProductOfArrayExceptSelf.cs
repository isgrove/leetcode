namespace LeetCode.Arrays
{
    public class ProductOfArrayExceptSelf
    {
        // Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
        // The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
        // You must write an algorithm that runs in O(n) time and without using the division operation.
        public static int[] Run(int[] nums)
        {
            var result = new int[nums.Length];
            var prefix = 1;
            var suffix = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            for (var i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= suffix;
                suffix *= nums[i];
            }

            return result;
        }

        [Fact]
        public void ProductOfArrayExceptSelfExample1()
        {
            var nums = new int[] { 1, 2, 3, 4 };
            var expected = new int[] { 24, 12, 8, 6 };
            var result = Run(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProductOfArrayExceptSelfExample2()
        {
            var nums = new int[] { -1, 1, 0, -3, 3 };
            var expected = new int[] { 0, 0, 9, 0, 0 };
            var result = Run(nums);

            Assert.Equal(expected, result);
        }
    }
}