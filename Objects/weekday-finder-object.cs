using System;

namespace weekdayFinder
{
  public class Finder
  {
    private string[] dayNames = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
    private int[] monthLengths = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    public string Find(string date)
    {
      int month = Int32.Parse(date.Substring(0,2));
      int day = Int32.Parse(date.Substring(2,2))-1;
      int year = Int32.Parse(date.Substring(4,4));
      int dayOfYear = AddMonths(month)+day;
      int totalDays = dayOfYear+AddYears(year, dayOfYear);
      return dayNames[totalDays%7];
    }
    public int AddMonths(int monthNumber)
    {
      int totalDays = 0;
      for(int i=0; i<monthNumber-1; i++)
      {
        totalDays += monthLengths[i];
      }
      return totalDays;
    }
    public int AddYears(int yearNumber, int day)
    {
      int totalDays = (yearNumber-1753)*365;
      int leapYears = 0;
      leapYears += (yearNumber/4)-438;
      leapYears -= (yearNumber/100)-17;
      leapYears += (yearNumber/400)-4;
      if(day <= 59 && ((yearNumber%4 == 0 && yearNumber%100 != 0) || yearNumber%400 == 0)){
        leapYears -=1;
      }
      totalDays += leapYears;
      return totalDays;
    }
  }
}
