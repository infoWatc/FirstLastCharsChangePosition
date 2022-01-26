/*
    Write a C# program to create a new string from a given 
    string where the first and last characters will change 
    their positions.
*/
using System;
public class Exercise1
{
    static void SwitchEnds(string letters)
    {
        char[] inputWord = letters.ToCharArray();
        char[] rearrange = new char[inputWord.Length];
        rearrange[0] = inputWord[inputWord.Length - 1];
        rearrange[rearrange.Length - 1] = inputWord[0];
        for (int i = 1; i < inputWord.Length - 1; i++)
        {
            rearrange[i] = inputWord[i];
        }
        foreach (char item in rearrange)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
    public static void Main()
    {   
        SwitchEnds("w3resource");
        SwitchEnds("python");
        SwitchEnds("x");
    }
}