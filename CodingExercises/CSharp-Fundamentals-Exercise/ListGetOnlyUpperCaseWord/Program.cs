using System.Runtime.CompilerServices;
using System.Threading;

namespace ListGetOnlyUpperCaseWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            {
                "one", "TWO", "THREE", "aD1!"
            };

            Console.WriteLine(string.Join(", ", GetOnlyUpperCaseWords(list)));

            //Test int.TryParse()
            //bool isValidInput;
            //do
            //{
            //    string input = Console.ReadLine();
            //    isValidInput = int.TryParse(input, out int result);

            //} while (!isValidInput);
        }

        public static List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            List<string> allUpperWords = new List<string>();
            foreach (var word in words)
            {
                //string currentWord = word;
                //if (currentWord == word.ToUpper() && word.All(x => char.IsLetter(x)))
                //{
                //    if (!allUpperWords.Contains(word))
                //    {
                //        allUpperWords.Add(word);
                //    }
                //}

                if (allUpperWords.Contains(word))
                {
                    continue;
                }
                if (IsUperCase(word))
                {
                    allUpperWords.Add(word);
                }
            }

            return allUpperWords;
        }

        public static bool IsUperCase(string word) 
        {
            foreach (var letter in word) 
            {
                if (char.IsUpper(letter))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
