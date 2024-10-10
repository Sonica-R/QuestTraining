using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a long long text";
            string[] words = text.Split(' ');
            string[] wordsFound = new string[words.Length];
            int wordsChecked = 0;

            foreach (var word in words)
            {
                if (wordsFound.Contains(word))
                {
                    continue;
                }
                int count = 0;
                foreach (var item in words)
                {
                    if (item == word)
                    {
                        count++;
                    }
                }
                wordsFound[wordsChecked] = word;
                wordsChecked++;
                Console.WriteLine($"{word} : {count}");
            }


            //Repeated count

            /*for (int i = 0; i < words.Length; i++)
               {
                int count = 0;
                string word = words[i];
                string temp = word;
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == word)
                    {
                        count++;
                    }

                }
                if (count > 2)
                {
                    Console.WriteLine($"{word} : {count}");
                }
                else
                {
                    Console.WriteLine($"{word} : {count}");
                }
               }*/


        }
    }
}
