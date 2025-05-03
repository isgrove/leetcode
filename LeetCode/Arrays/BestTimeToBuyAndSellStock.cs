namespace LeetCode.Arrays
{
    public class BestTimeToBuyAndSellStock
    {
        // You are given an array prices where prices[i] is the price of a given stock on the ith day.
        //
        // You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
        //
        // Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
        public static int Run(int[] prices)
        {
            var min = int.MaxValue;
            var profit = 0;
            int curr;

            for (var i = 0; i < prices.Length; i++)
            {
                curr = prices[i];

                if (min > curr)
                    min = curr;

                if (curr - min > profit)
                    profit = curr - min;
            }

            return profit;
        }

        [Fact]
        public void BestTimeToBuyAndSellStockExample1()
        {
            var prices = new int[] { 7, 1, 5, 3, 6, 4 };
            var expected = 5;
            var result = Run(prices);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void BestTimeToBuyAndSellStockExample2()
        {
            var prices = new int[] { 7, 6, 4, 3, 1 };
            var expected = 0;
            var result = Run(prices);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void BestTimeToBuyAndSellStockExample3()
        {
            var prices = new int[] { 2, 4, 1 };
            var expected = 2;
            var result = Run(prices);

            Assert.Equal(expected, result);
        }
    }
}