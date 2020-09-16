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
            var switchedUserInput = userInput;
            var counter = 0;

            foreach (var character in userInput)
            {
                if (char.IsLower(character))
                {
                    switchedUserInput = switchedUserInput.Remove(counter, 1).Insert(counter, char.ToString(switchedUserInput[counter]).ToUpper());
                }
                else
                {
                   switchedUserInput = switchedUserInput.Remove(counter, 1).Insert(counter, char.ToString(switchedUserInput[counter]).ToLower());
                }
                counter++;
            }

            return switchedUserInput;
        }
    }
}
