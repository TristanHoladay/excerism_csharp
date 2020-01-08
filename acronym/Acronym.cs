using System;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string abbreviation = "";

        //regex says: split only if characters are not alphanumeric and not ' OR only if character is _
        string[] words = Regex.Split(phrase, @"[^\w+']|[_]");

        //iterate through the words array
        for(var i = 0; i < words.Length; i++)
        {
            //if statement put in place to handle ArgumentOutOfRange exception
            if(words[i].Length > 0)
            {
                string letter = words[i].Substring(0, 1);
                abbreviation += letter;
            }
        }

        return abbreviation.ToUpper();
    }
}