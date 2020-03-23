using System;
using System.Collections.Generic;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int userNumber = 4;
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6};
            p.GuessMyNumber(list, userNumber);
        }


        public void GuessMyNumber(List<int> list, int userNumber)
        {
            List<int> newList = new List<int>();
            int listLength = list.Count;
            int midNumber = list[listLength / 2];

            if(userNumber == midNumber)
            {
                Console.WriteLine($"Your number is {midNumber}");
            }
            else if (userNumber < midNumber) 
            {
                for (int i = 0; i < listLength / 2; i++)
                {
                    newList.Add(list[i]);
                }
                    GuessMyNumber(newList, userNumber);
            }
            else if (userNumber > midNumber)
            {
                for (int i = listLength / 2; i < listLength; i++)
                {
                    newList.Add(list[i]);
                }
                    GuessMyNumber(newList, userNumber);
            }
            
            

        }
    }
}
