public class Solution {
    public int DayOfYear(string date) {
        int year = Int32.Parse(date.Substring(0, 4));
        int month = Int32.Parse(date.Substring(5, 2));
        int day = Int32.Parse(date.Substring(8, 2));

        if(month == 1) return day;
        
        int sumDays = day;
        for(int i = 1; i < month; i++) {
            sumDays += DateTime.DaysInMonth(year, i);
        }

        return sumDays;
    }
}