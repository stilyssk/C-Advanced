using System;
using System.Collections.Generic;
using System.Linq;

public class DateModifier
{
    
    private DateTime firstDate;
    private DateTime secondDate;
    public DateModifier()
    {

    }
    public DateModifier (string inputFirstDate,string inputSecondDate)
    {
        this.FirstDate = inputFirstDate;
        this.SecondDate = inputSecondDate;
    }

    public string FirstDate
    {
        set
        {
            List<int> convertValueToInt = value
                .Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int year = convertValueToInt[0];
            int mounth = convertValueToInt[1];
            int days = convertValueToInt[2];

            DateTime inputDateTime = new DateTime(year,mounth,days);


            firstDate = inputDateTime;
        }
    }

    public string SecondDate
    {
        set
        {
            List<int> convertValueToInt = value
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int year = convertValueToInt[0];
            int mounth = convertValueToInt[1];
            int days = convertValueToInt[2];

            DateTime inputDateTime = new DateTime(year, mounth, days);


            secondDate = inputDateTime;
        }
    }

    public int DayDifference()
    {
            
        return Math.Abs((secondDate - firstDate).Days);
    }

    public string PrintResult()
    {
        return $"{DayDifference()}";
    }

}
