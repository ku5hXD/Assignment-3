// See https=//aka.ms/new-console-template for more information

using System;

namespace Program
{
    class IsItASentence
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sentence?");
            string str = Console.ReadLine();
            Console.WriteLine($"\n Length of sentence is : {str.Length}\n");

            if (str[str.Length - 1] == '.')
            {
                Console.WriteLine("The sentence represents a declarative sentence.\n");
            }
            else if (str[str.Length - 1] == '?')
            {
                Console.WriteLine("The sentence represents a interrogatory sentence.\n");
            }
            else if (str[str.Length - 1] == '!')
            {
                Console.WriteLine("The sentence represents a exclamation sentence.\n");
            }
            else
            {
                Console.WriteLine("The string entered is not a sentence.\n");
            }

            Console.WriteLine("Enter your name?\n");
            string name = Console.ReadLine();

            int i = 0;
            while (i < name.Length - 1 && name[i] != ' ')
            {
                i++;
            }

            if (i >= name.Length - 1)
            {
                Console.WriteLine($"{name}\n");
            }
            else
            {
                string firstName = name.Substring(0, i);
                i++;
                string lastName = name.Substring(i, name.Length - i);

                Console.WriteLine($"\n{lastName}, {firstName}");
            }
        }
    }


}

