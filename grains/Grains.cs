using System;

public static class Grains
{

    public static ulong Square(int n)
    {
        //ulong grains = 1;

        if(n < 1 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }

        if(n > 1)
        {
            //for (int i = 2; i < n + 1; i++)
            //{
            //     grains *= 2;
            //}
            return (ulong)Math.Pow(2, n - 1);
        }

        return (ulong)1;
    }

    public static ulong Total()
    {
        //ulong grain = 1;
        //ulong totalGrain = grain;
        //int n = 1;

        //while(n < 65)
        //{
        //    totalGrain += (grain *= 2);
        //    n++;
        //}

        return (ulong)Math.Pow(2, 65) - 1;
        
    }
}