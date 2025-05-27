namespace DSA_Runtime.Easy
{
    public class RemoveDuplicateFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 0) return 0;
            int x = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[x] != nums[i])
                {
                    x++;
                    nums[x] = nums[i];
                }
            }
            return x + 1;
        }
    }
}