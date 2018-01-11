using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                if (text.Contains(currentWord))
                {
                    text = text.Replace(words[i], new string('*', currentWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
