namespace DSA_Runtime.Easy
{
    public class LongestCommenPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            //{ "flower", "flow", "flight" };

            string response = "";
            if (strs == null || strs.Length == 0) return response;

            for (int i = 0; i < strs[0].Length; i++)
            {
                char currentChar = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length) return response;
                    if (strs[j][i] != currentChar) return response;
                }
                response += currentChar;
            }
            return response;
        }
    }
}
