using System;
public static class GameUtils
{
    public static int Clamp(int value, int min, int max)
    {
        if (value < min)
            return min;
        if (value > max)
            return max;

        return value;
    }

    public static int GetPercentage(int current, int max)
    {
        if (max == 0)
            return 0; 
        return (current * 100) / max;
    }

    public static bool IsInRange(int value, int min, int max)
    {
        return value >= min && value <= max;
    }
}