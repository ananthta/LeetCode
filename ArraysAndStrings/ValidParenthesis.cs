using System.Linq;
using System.Collections.Generic;

namespace LeetCode.ArraysAndStrings
{
    public class ValidParenthesis : IValidParenthesis
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
                return true;

            foreach (var parenthesis in s)
            {
                if (_closeToOpenParenthesisMap.ContainsKey(parenthesis))
                {
                    if (_parenthesisStack.Count == 0 ||
                        _parenthesisStack.Peek() != _closeToOpenParenthesisMap[parenthesis])
                        return false;
                    else
                    {
                        _parenthesisStack.Pop();
                    }
                }
                else if (_openParenthesis.Contains(parenthesis))
                {
                    _parenthesisStack.Push(parenthesis);
                }
            }

            return _parenthesisStack.Count <= 0;
        }

        private readonly Stack<char> _parenthesisStack = new Stack<char>();
        private readonly char[] _openParenthesis = {'(', '{', '['};
        private readonly Dictionary<char, char> _closeToOpenParenthesisMap =
            new Dictionary<char, char> {{')', '('}, {'}', '{'}, {']', '['}};
        
    }
}