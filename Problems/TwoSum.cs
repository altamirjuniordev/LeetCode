namespace LeetCode.Problems
{
    public static class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            Dictionary<int, int> numerosParaSomar = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int quantoFalta = target - nums[i];

                if (numerosParaSomar.ContainsKey(quantoFalta))
                {
                    return new int[]
                    {
                    numerosParaSomar[quantoFalta], i
                    };
                }
                numerosParaSomar[nums[i]] = i;
            }
            return new int[0];
        }
    }
}