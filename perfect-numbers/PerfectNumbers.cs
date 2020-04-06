using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        int sum;

        if (number < 1)
        {
            throw new ArgumentOutOfRangeException();
        }

        sum = AliquotSum(number);

        if(sum == number)
        {
            return Classification.Perfect;
        } 
        else if(sum > number)
        {
            return Classification.Abundant;
        }
        else
        {
            return Classification.Deficient;
        }

    }

    private static int AliquotSum(int number)
    {
        int sum = 0;

        for (int factor = 1; factor < number; factor++)
        {
            if (number % factor == 0)
            {
                sum += factor;
            }
        }

        return sum;
    }
}
