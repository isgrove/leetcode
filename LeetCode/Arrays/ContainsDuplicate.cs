namespace LeetCode.Arrays
{
    public class ContainsDuplicate
    {
        // Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        public static bool Run(int[] nums)
        {
            HashSet<int> set = [];
            int curr;

            for (var i = 0; i < nums.Length; i++)
            {
                curr = nums[i];

                if (set.Contains(curr))
                    return true;

                set.Add(curr);
            }

            return false;
        }

        [Fact]
        public void ContainsDuplicateExample1()
        {
            var nums = new int[] { 1, 2, 3, 1 };
            var expected = true;
            var result = Run(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ContainsDuplicateExample2()
        {
            var nums = new int[] { 1, 2, 3, 4 };
            var expected = false;
            var result = Run(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ContainsDuplicateExample3()
        {
            var nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            var expected = true;
            var result = Run(nums);

            Assert.Equal(expected, result);
        }
    }
}