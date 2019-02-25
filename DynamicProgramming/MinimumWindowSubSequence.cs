
namespace LeetCode.DynamicProgramming
{
    public class MinimumWindowSubSequence : IMinimumWindowSubSequence
    {
        public string MinWindow(string S, string T)
        {
            if (string.IsNullOrEmpty(S) || string.IsNullOrEmpty(T))
                return null;

            if (T.Length > S.Length)
                return null;

            var sCharCount = new int[256];
            var tCharCount = new int[256];

            foreach (var t in T)
            {
                tCharCount[t]++;
            }

            var count = 0;
            var start = 0;
            var windowStartIndex = -1;
            var windowEndIndex = -1;
            var minWindowLength = int.MaxValue;

            for (var i = 0; i < S.Length; i++)
            {
                sCharCount[S[i]]++;

                if (tCharCount[S[i]] != 0 && sCharCount[S[i]] <= tCharCount[S[i]])
                    count++;

                if (count != T.Length) continue;
                while (sCharCount[S[start]] > tCharCount[S[start]] || tCharCount[S[start]] == 0)
                {
                    if (sCharCount[S[start]] > tCharCount[S[start]])
                        sCharCount[S[start]]--;
                    start++;
                }

                var currWindowLength = i - start + 1;
                if (currWindowLength >= minWindowLength) continue;
                minWindowLength = currWindowLength;
                windowStartIndex = start;
                windowEndIndex = i;
            }
            
            if (windowStartIndex < 0 || windowEndIndex < 0)
                return null;

            var subStr = S.Substring(windowStartIndex, (windowEndIndex - windowStartIndex) + 1);
            return subStr;
        }
    }
}