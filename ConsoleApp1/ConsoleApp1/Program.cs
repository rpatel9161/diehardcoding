using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1   
{
    class Program
    {

        static int RepeatingChar(string input)
        {
          
            int currentPointer = -1, i, j;

            for (i = 0; i < input.Length; i++)
            {
                for (j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        currentPointer = i;
                        break;
                    }
                }
                if (currentPointer != -1)
                    break;
            }

            return currentPointer;
        }

      
        static public void Main()
        {
            string userInput = "STRRSTRA";
            int Positive = RepeatingChar(userInput);

            if (Positive == -1)
                Console.WriteLine("Not found");
            else
                Console.WriteLine("The repeating character into the string is:   {0}",userInput[Positive]);
            Console.ReadKey();
        }

    }
}
