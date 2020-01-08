using System;

public static class ResistorColor
{
    private static readonly string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    public static int ColorCode(string color)
    {
        //finding index of the given string by calling the Colors method which returns a string array
        return Array.IndexOf(colors, color);
    }

    public static string[] Colors()
    {
        return colors;
    }
}