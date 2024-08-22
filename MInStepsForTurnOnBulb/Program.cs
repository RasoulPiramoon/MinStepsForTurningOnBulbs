// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public static class Solution
{
    public static int solve(int A)
    {
        int minStep = 0;
        if (A == 1)
            minStep = 1;
        else if (A == 2 || A == 3)
            minStep = 2;
        else if (A > 3)
        {
            int i = 3;
            while (true)
            {
                minStep++;
                i++;
                if (i > A)
                {
                    minStep++;
                    break;
                }
                minStep++;
                if ((i + 5) > A)
                {
                    if ((A - i) == 3)
                        minStep++;
                    else if ((A - i) == 4)
                        minStep = minStep + 2;
                    break;
                }
                i = i + 5;
            }
        }
        return minStep;
    }
}