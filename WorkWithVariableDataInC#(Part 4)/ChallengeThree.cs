using System;

class ChallengeThree
{
    static void Main(string[] args)
    {
        string sentence = "The quick brown fox jumps over the lazy dog";
        string[] words = sentence.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            char[] characters = words[i].ToCharArray();
            Array.Reverse(characters);
            words[i] = new string(characters);
        }
        string result = String.Join(" ", words);
        Console.WriteLine(result);
    }
}