using System;
using System.Linq;
using System.Text;

namespace CaseSwitcher
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter a word or sentence.");
            var userInput = Console.ReadLine();

            Console.WriteLine(CaseSwitch(userInput));
        }

        static string CaseSwitch(string userInput)
        {
            var switchedUserInput = new StringBuilder();
            var i = 0;

            foreach (var character in userInput)
            {
                if (char.IsLower(character))
                {
                    switchedUserInput.Append(char.ToUpper(character));
                }
                else
                {
                    switchedUserInput.Append(char.ToLower(character));
                }

                i++;
            }

            return switchedUserInput.ToString();
        }
    }
}
