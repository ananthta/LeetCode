using System;
using System.Linq;
using LeetCode.Models;
using System.Collections.Generic;

namespace LeetCode.SortingAndSearching
{
    public class MergeIntervals : IMergeIntervals
    {
        public IList<Interval> Merge(IList<Interval> intervals) {
            var result = new List<Interval>();

            if (intervals == null || intervals.Count <= 0)
                return result;
            
            var sortedIntervals = intervals.OrderBy(i => i.start).ToList();

            var mergedInterval = sortedIntervals[0];
            for (var i = 1; i < sortedIntervals.Count; i++)
            {
                if (sortedIntervals[i].start <= mergedInterval.end)
                {
                    mergedInterval.end = Math.Max(mergedInterval.end, sortedIntervals[i].end);
                }
                else
                {
                    result.Add(mergedInterval);
                    mergedInterval = sortedIntervals[i];
                }
            }

            result.Add(mergedInterval);
            return result;
        }
    }
}