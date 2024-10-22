using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0) 
            throw new ArgumentOutOfRangeException(nameof(number),"Number must be greater than 0");
        
        int steps = 0;
        
        while (number != 1)
        {
            if (number % 2 == 0) number /= 2;
            else number = number * 3 + 1;
            steps++;
        }

        return steps;
    }
}