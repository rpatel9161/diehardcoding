using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1   
{
   public class Program12
    {

        public int RepeatingChar(string input)
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

          }
}
