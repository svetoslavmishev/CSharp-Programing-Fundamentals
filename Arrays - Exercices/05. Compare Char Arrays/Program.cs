using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var array2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            CompareCharArray(array1, array2);
        }

        private static void CompareCharArray(char[] array1, char[] array2)
        {
            bool isOnTop = false;

            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] < array2[i])
                    {
                        isOnTop = true;
                    }
                    else
                    {
                        isOnTop = false;
                        break;
                    }
                }
            }
            else if (array1.Length < array2.Length)
            {
                isOnTop = true;
            }
            else
            {
                isOnTop = false;
            }

            if (isOnTop)
            {
                Console.WriteLine(string.Join("", array1));
                Console.WriteLine(string.Join("", array2));
            }
            else
            {
                Console.WriteLine(string.Join("", array2));
                Console.WriteLine(string.Join("", array1));
            }
        }
    }
}