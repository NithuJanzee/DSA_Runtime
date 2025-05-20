namespace DSA_Runtime.Easy
{
    public class TwoSum
    {
        //int[] nums = [2, 7, 5, 1];
        //int target = 9;
        //int output = [0, 1];
        public int[] TwoSumQuetion(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target) return new int[] { i, j };
                }
            }
            return new int[] { 0 };
        }
    }
}
