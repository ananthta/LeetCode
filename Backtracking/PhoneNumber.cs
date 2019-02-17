using System.Collections.Generic;
using LeetCode.TreesAndGraphs;

namespace LeetCode.Backtracking
{
    public class PhoneNumber : IPhonenumber
    {
        private readonly IList<string> _result = new List<string>();
        private readonly Dictionary<char, string> _numToCharsMap = new Dictionary<char, string>(){
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };
    
        public IList<string> LetterCombinations(string digits) {
            GetAllCombinations(digits, 0, "");
            return _result;
        }

        private void GetAllCombinations(string digits, int digitPos, string currCombination)
        {        
            if(digitPos == digits.Length){
                _result.Add(currCombination);
                return;
            }
        
            _numToCharsMap.TryGetValue(digits[digitPos], out var chars);
            if (chars == null) return;
            
            foreach (var ch in chars)
            {
                GetAllCombinations(digits, digitPos + 1, currCombination + ch);
            }
        }
    }
}