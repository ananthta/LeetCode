namespace LeetCode.Models
{
    public class Interval
    {
        public int start { get; private set; }
        public int end { get; set; }

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