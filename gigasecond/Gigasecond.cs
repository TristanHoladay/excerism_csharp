using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        //adding a gigasecond to the given moment and returning the new date
        return moment.AddSeconds(1e9);
    }


}