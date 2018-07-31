using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EliminateDuplicateTickets
    {

        public class Program
        {
            public static void Main(string[] args)
            {
               Console.WriteLine("Unique key into the string is :   {0}  ",FindUniqueTicketsinTheBuffer("aaacfffdggg"));
                Console.WriteLine("---------------------------------------------------------------\n Now finding repetative character into the stream \n\n");

                Program12 findRep = new Program12();
                string userInput = "STRRSTRA";
                int Positive =  findRep.RepeatingChar(userInput);
                
               
                if (Positive == -1)
                    Console.WriteLine("Not found");
                else
                    Console.WriteLine("The repeating character into the string is:   {0}", userInput[Positive]);

                Console.ReadKey();
            }



            public static char FindUniqueTicketsinTheBuffer(string str)
            {
                Dictionary<char, int> charCount = new Dictionary<char, int>();     // Hold the key value pair for char and char count
                int temp = 0;

                foreach (char key in str.ToCharArray())         // iterating all the keys under dictionary
                {
                    if (charCount.Keys.Contains(key))
                    {
                        temp = charCount[key];                 //saving value in temp
                        charCount[key] = temp + 1;
                        continue;
                    }
                    charCount.Add(key, 1);                      // adding unique keys into the dictionary
                }

                if (charCount.Values.Contains(1))
                {
                    return charCount.First(x => x.Value == 1).Key;       // returning key of the count 1
                }
                return ' ';
            }

        }
    }
}
