using System.Collections;

public class Isomorphic
{
    //if doesn't exist add to hashtable add e.g p = 1 and t = 2 for both s and t
    // if the letter equals a number check against each list e.g. s = 1 and t = 1 then true else s = 2 and t = 1 equals false

    public static bool IsIsomorphic(string s, string t)
    {
        var length = s.Length;
        if (length == 0) return false;
        if (length == 1) return true;

        Hashtable sHashTable = new Hashtable(), tHashTable = new Hashtable();

        int counter = 0, sCounter = 0, tCounter = 0;

        while (counter < length)
        {
            char sChar = s[counter], tChar = t[counter];
            if (!sHashTable.ContainsKey(sChar)) sHashTable.Add(sChar, sCounter++);
            if (!tHashTable.ContainsKey(tChar)) tHashTable.Add(tChar, tCounter++);

            if (sHashTable[sChar]?.ToString() != tHashTable[tChar]?.ToString()) return false;
            counter++;
        }

        return true;
    }
}