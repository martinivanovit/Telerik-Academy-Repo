using System;
using System.Text;

public static class SubstringExtension
{
    public static StringBuilder Substring(this StringBuilder stringBuilder, int startIndex)
    {
        ArgumentOutOfRangeException outOfRangeException = new ArgumentOutOfRangeException("No such index!", "You must enter positive number smaller than the size of the collection");
        if (startIndex < 0 || startIndex >= stringBuilder.Length)
        {
            throw outOfRangeException;
        }

        string build = stringBuilder.ToString().Substring(startIndex);

        stringBuilder.Clear();
        stringBuilder.Append(build);

        return stringBuilder;
    }
    
    public static StringBuilder Substring(this StringBuilder stringBuilder, int startIndex, int length)
    {
        ArgumentOutOfRangeException outOfRangeException = new ArgumentOutOfRangeException("No such index!", "You must enter positive number smaller than the size of the collection");
        if (startIndex < 0 || startIndex >= stringBuilder.Length)
        {
            throw outOfRangeException;
        }
        if (startIndex + length >= stringBuilder.Length)
        {
            throw outOfRangeException;
        }

        string build = stringBuilder.ToString().Substring(startIndex, length);

        stringBuilder.Clear();
        stringBuilder.Append(build);

        return stringBuilder;
    }


    static void Main()
    {
        StringBuilder a = new StringBuilder();
        a.Append("Musaka s tarator");
        //Console.WriteLine(a.Substring(4));
        Console.WriteLine(a.Substring(0, 3));
        string s = "Musaka s tarator";
        Console.WriteLine(s.Substring(0,3));
    }
}

