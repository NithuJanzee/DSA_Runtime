using System.Collections.Generic;

namespace DSA_Runtime.Easy
{
    public class RomanToInt
    {
        public int RomanToIntQ(string s)
        {
            s.ToUpper();
            var map = new Dictionary<char, int>
                {
                    {'I', 1},
                    {'V', 5},
                    {'X', 10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500},
                    {'M', 1000}
                };

            int OutPut = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int CurrentValue = map[s[i]];
                if (i + 1 < s.Length && CurrentValue < map[s[i + 1]]) OutPut -= CurrentValue;
                else OutPut += CurrentValue;
            }
            return OutPut;
        }
    }
}
