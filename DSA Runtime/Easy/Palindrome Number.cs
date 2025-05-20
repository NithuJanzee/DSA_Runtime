namespace DSA_Runtime.Easy
{
    public class Palindrome_Number
    {
        public bool IsPalindrom(int x)
        {
            if (x < 0) return false;
            int original = x;
            int reverce = 0;
            while (x > 0)
            {
                int digit = x % 10;
                reverce = reverce * 10 + digit;
                x = x / 10;
            }
            return original == reverce;
        }
    }
}
