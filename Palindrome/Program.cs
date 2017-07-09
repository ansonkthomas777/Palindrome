using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {

        static bool CheckPalindrome(string CheckString)
        {
            if (CheckString == null || CheckString.Length == 0)
            {
                return false;
            }
            int strMaxIndex = CheckString.Length - 1;
            for (int i = 0; i < CheckString.Length / 2; i++)
            {
                if (CheckString[i] != CheckString[strMaxIndex - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int length=0;
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            length = str.Length;            
            
            if (CheckPalindrome(str))
            {
                Console.WriteLine("{0} is a Palindrome String", str);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome String", str);
            }

            Console.ReadLine();
        }
    }
}
