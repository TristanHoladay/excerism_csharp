using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        //    if (year % 4 != 0)
        //        return false;

        //    if (year % 100 == 0)
        //    {
        //        if(year % 400 == 0)
        //        {
        //            //year is divisible by 4, 100, and 400
        //            return true;
        //        }

        //        //year is divisible by 4 and 100
        //        return false;
        //    }

        //    //year is divisible by 4 and not by 100
        //    return true;

        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}


