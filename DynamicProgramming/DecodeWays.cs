using System;

namespace LeetCode.DynamicProgramming
{
    public class DecodeWays : IDecodeWays
    {
        public int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s) || s[0] == '0')
                return 0;

            if (s.Length == 1)
                return 1;
            
            var inputLength = s.Length;
            var dp = new int[inputLength + 1];

            dp[0] = 1;
            dp[1] = s[1] != '0' ? 1 : 0;

            for (var i = 2; i <= inputLength; i++)
            {
                var firstChar = s.Substring(i - 1, 1);
                var secondChar = s.Substring(i - 2, 2);

                var firstCharAsNumber = Convert.ToInt32(firstChar);
                var secondCharAsNumber = Convert.ToInt32(secondChar);

                if (firstCharAsNumber > 0 && firstCharAsNumber <= 9)
                    dp[i] += dp[i - 1];
                if (secondCharAsNumber >= 10 && secondCharAsNumber <= 26)
                    dp[i] += dp[i - 2];
            }

            return dp[s.Length];
        }
    }
}