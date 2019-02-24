using LeetCode.Models;
using System.Collections.Generic;

namespace LeetCode.SortingAndSearching
{
    public interface IMergeIntervals
    {
        IList<Interval> Merge(IList<Interval> intervals);
    }
}