using System;
using LeetCode.Models;

namespace LeetCode.SortingAndSearching
{
    public class MeetingRooms : IMeetingRooms
    {
        public int MinMeetingRooms(Interval[] intervals)
        {
            if (intervals == null || intervals.Length == 0)
                return 0;

            var startTimes = new int[intervals.Length];
            var endTimes = new int[intervals.Length];

            for (var i = 0; i < intervals.Length; i++)
            {
                startTimes[i] = intervals[i].start;
                endTimes[i] = intervals[i].end;
            }
            
            Array.Sort(startTimes);
            Array.Sort(endTimes);

            var rooms = 0;
            var endPointer = 0;

            foreach (var t in startTimes)
            {
                if (t < endTimes[endPointer])
                    rooms++;
                else
                {
                    endPointer++;
                }
            }

            return rooms;
        }
    }
}