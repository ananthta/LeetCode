using System;
using System.Collections.Generic;
using LeetCode.Models;

namespace LeetCode.SortingAndSearching
{
/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
	public class Solution
	{
		public int MinMeetingRooms(Interval[] intervals)
		{
			Array.Sort(intervals, (x, y) => x.start.CompareTo(y.start));
			var meetingRooms = new MinHeap(intervals.Length);
			var maxRooms = 0;
			foreach (var t in intervals)
			{
				while (meetingRooms.Count > 0 && t.start >= meetingRooms.First().end)
				{
					meetingRooms.RemoveFirst();
				}

				meetingRooms.Add(t);
				if (meetingRooms.Count > maxRooms)
					maxRooms = meetingRooms.Count;
			}

			return maxRooms;
		}

		private class MinHeap
		{
			private readonly Interval[] _sortedLists;
			public int Count { get; private set; }

			public MinHeap(int size)
			{
				_sortedLists = new Interval[size];
				Count = 0;
			}

			public MinHeap(IReadOnlyCollection<Interval> lists)
			{
				Count = 0;
				_sortedLists = new Interval[lists.Count];
				foreach (var t in lists)
				{
					if (t != null)
						this.Add(t);
				}
			}

			public Interval First()
			{
				return _sortedLists[0];
			}

			public Interval RemoveFirst()
			{
				var node = _sortedLists[0];
				_sortedLists[0] = _sortedLists[Count - 1];
				Count--;
				BubbleDown();
				return node;
			}

			private void BubbleDown()
			{
				var cur = 0;
				while (cur < Count)
				{
					var leftChild = cur * 2 + 1;
					var rightChild = leftChild + 1;

					// no children case - bail
					if (leftChild >= Count)
						break;

					var swapCandidate = leftChild;
					if (rightChild < Count && _sortedLists[rightChild].end < _sortedLists[swapCandidate].end)
					{
						swapCandidate = rightChild;
					}


					// if violates heap prop with swapCandidate child, swap
					if (_sortedLists[cur].end > _sortedLists[swapCandidate].end)
					{
						Interval temp = _sortedLists[cur];
						_sortedLists[cur] = _sortedLists[swapCandidate];
						_sortedLists[swapCandidate] = temp;
						cur = swapCandidate;
					}
					else
						break; // heap property intact
				}
			}

			public void Add(Interval node)
			{
				_sortedLists[Count] = node;
				Count++;
				BubbleUp();
			}

			private void BubbleUp()
			{
				var cur = Count - 1;
				while (cur > 0)
				{
					var parent = (cur - 1) / 2;
					// heap violation
					if (_sortedLists[parent].end > _sortedLists[cur].end)
					{
						var temp = _sortedLists[cur];
						_sortedLists[cur] = _sortedLists[parent];
						_sortedLists[parent] = temp;
						cur = parent;
					}
					else break;
				}
			}
		}
	}
}