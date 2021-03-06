Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), 
determine if a person could attend all meetings.

For example,
Given [[0, 30],[5, 10],[15, 20]],
return false.


/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    // sort according to start time
    public bool CanAttendMeetings(Interval[] intervals) {
        List<Interval> list = new List<Interval>(intervals);
        list.Sort(new Comparison<Interval>((x,y) => x.start - y.start));
        
        for (int i = 1; i < list.Count; i++) {
            if (list[i].start < list[i - 1].end) return false;
        }
        return true;
    }
}