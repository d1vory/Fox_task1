using System.Text;

namespace Task1;

public class Anagram
{
    public static string Reverse(string input)
    {
        if (input == null) throw new ArgumentNullException(nameof(input));
        if (input.Length == 0) return input;

        StringBuilder result = new StringBuilder();
        List<StringBuilder> words = SplitWords(input);
        foreach (StringBuilder word in words)
        {
            string reversedWord = ReverseWord(word.ToString());
            result.Append(reversedWord);
        }

        return result.ToString();
    }

    private static string ReverseWord(string word)
    {
        if (String.IsNullOrWhiteSpace(word))
        {
            return word;
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

    
    private static List<StringBuilder> SplitWords(string input)
    {
        List<StringBuilder> splittedWords = new List<StringBuilder>();

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            if (splittedWords.Count == 0)
            {
                splittedWords.Add(new StringBuilder(ch.ToString()));
                continue;
            }

            StringBuilder currentWord = splittedWords[splittedWords.Count-1];
            bool isCurrentWordSpaces = currentWord[0] == ' ';

            if (ch == ' ')
            {
                if (isCurrentWordSpaces)
                {
                    currentWord.Append(ch);
                }
                else
                {
                    splittedWords.Add(new StringBuilder(ch.ToString()));
                }
            }
            else
            {
                if (isCurrentWordSpaces)
                {
                    splittedWords.Add(new StringBuilder(ch.ToString()));
                }
                else
                {
                    currentWord.Append(ch);
                }
            }
        }

        return splittedWords;
    }


}