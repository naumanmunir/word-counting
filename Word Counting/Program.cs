using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace Word_Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable stores the file
            string inputText = System.IO.File.ReadAllText(@"C:\Users\nonabona\Desktop\Test.txt");
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            char empty = ' ';

            string[] words = Regex.Split(inputText.ToLower(), @"[^\w]|[\d]|[\s]+");


            for(int i = 0; i < inputText.Length; i++)
            {
                string[] source = inputText.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                

                Console.WriteLine(inputText);
                
                
            }

        }

    }


}
