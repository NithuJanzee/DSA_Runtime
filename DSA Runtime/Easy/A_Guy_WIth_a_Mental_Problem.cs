namespace DSA_Runtime.Easy
{
    public class A_Guy_WIth_a_Mental_Problem
    {
        public int FindMinimumTIme(int[] arr1, int[] arr2)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 += arr1[i];
                    sum2 += arr2[i];
                }
                else
                {
                    sum1 += arr2[i];
                    sum2 += arr1[1];
                }
            }
            if (sum1 > sum2) return sum2;
            else return sum1;
        }
    }
}
