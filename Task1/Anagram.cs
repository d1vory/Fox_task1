using System.Text;

namespace Task1;

public class Anagram
{
    public static string ReverseWord(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            throw new ArgumentNullException(nameof(word));
        }
        StringBuilder resultWord = new StringBuilder();
        Dictionary<int, char> nonLetterIndices = new Dictionary<int, char>();
        for (int i = 0; i < word.Length; i++)
        {
            char ch = word[i];
            if (Char.IsLetter(ch))
            {
                resultWord.Insert(0, ch);
            }
            else
            {
                nonLetterIndices.Add(i, ch);
            }
        }
        foreach (var item in nonLetterIndices)
        {
            resultWord.Insert(item.Key, item.Value);
        }
        return resultWord.ToString();
    }

    public static string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException(nameof(input));
        }

        StringBuilder result = new StringBuilder(input);
        string [] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            string reversedWord = ReverseWord(word);
            result.Replace(word, reversedWord);
        }
        return result.ToString();
    }
}