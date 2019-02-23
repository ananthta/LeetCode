namespace LeetCode.Models
{
    public class Interval
    {
        public readonly int start;
        public readonly int end;

        public Interval()
        {
            start = 0;
            end = 0;
        }

        public Interval(int s, int e)
        {
            start = s;
            end = e;
        }
    }
}