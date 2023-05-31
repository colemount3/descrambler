using System;
using System.Collections.Generic;

public class Scramblies
{

    public static bool Scramble(string str1, string str2)
    {
        string answer = "";
        LinkedList<char> storage = new LinkedList<char>();
        foreach (char t in str1)
        {
            storage.AddLast(t);

        }

        for (int i = 0; i < str2.Length; i++)
        {
            if (storage.Contains(str2[i]))
            {
                storage.Remove(str2[i]);

                answer += str2[i];



            }
        }
        if (answer == str2)
        { return true; }
        else
        {
            return false;
        }
    }
        
    }

