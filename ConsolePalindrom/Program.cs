using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//проверка, является ли введённая строка палиндромом
namespace ConsolePalindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string str= Console.ReadLine();
            if (ItsPalindrome(str))
            {
                Console.WriteLine("строка является палиндромом");
            }
            else
            {
                Console.WriteLine("строка не является палиндромом");
            }
            Console.ReadKey();
        }

        static bool ItsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            while (left<right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
