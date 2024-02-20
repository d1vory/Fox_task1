using System.Text;

namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string userInput = Console.ReadLine();
        Console.WriteLine(Anagram.Reverse(userInput));
    }
}