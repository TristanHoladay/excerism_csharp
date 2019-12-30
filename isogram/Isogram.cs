using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {

        //handle case variances
        string lowCaseWord = word.ToLower();

        //check for empty string
        if (String.IsNullOrEmpty(lowCaseWord))
        {
            return true;
        }

        //compare each letter of the word to every other letter
        for(var i = 0; i < lowCaseWord.Length; i++)
        {
            //skip iteration if the character is a space or hyphen
            if(lowCaseWord[i].ToString() == " " || lowCaseWord[i].ToString() == "-")
            {
                continue;
            }

            for(var j = 0; j < lowCaseWord.Length; j++)
            {
                
                //don't compare the selected letter to itself
                if(i == j)
                {
                    continue;
                }

                if(lowCaseWord[i] == lowCaseWord[j])
                {
                    return false;
                }
            }
        }
        return true;

    }
}
