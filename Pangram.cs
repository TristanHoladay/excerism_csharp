using System;

public static class Pangram
{
    private static string alphabet = "abcdefghijklmnopqrstuvwxyz";

    public static bool IsPangram(string input)
    {

        if (input != "")
        {
            if (input == alphabet)
            {
                return true;
            }
            
            //iterate through the alphabet
            for (int i = 0; i < alphabet.Length; i++)
            {
                char letter = alphabet[i];

                //Handle case variances 
                string lowInput = input.ToLower();

                //check if letter does NOT exist in the input sentence
                if (!lowInput.Contains(letter))
                {
                    return false;
                }
            }

            return true;
        }
        else
        { 
            //input is empty
            return false;
        } 
    }

}
