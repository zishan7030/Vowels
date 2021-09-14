using System;

namespace Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter The Charecter");
            ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'a':
                case 'A': Console.WriteLine("It is a Vowel");
                    break;
                   
                case 'i':
                case 'I':

                    Console.WriteLine("It is a Vowel");
                    break;
                case 'o':
                case 'O':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'u':
                case 'U':
                    Console.WriteLine("It is a Vowel");
                    break;
                default:
                    Console.WriteLine("It is a Consonant");
                    break;
            }
        }
    }
}
