using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_Task2
{
   static class Extension
    {
        #region Polendrom
        public static void Polen(this int number)
        {
            //int sum = 0;
            //int a;
            //int b = number;          //121 , 12   =1 , 12

            //while (b>0)
            //{
            //    a = b % 10;         //1 , 2
            //    sum = sum * 10 + a; //0*10+1=1 , 1*10+2=12 , 12*10+1=121
            //    b = b / 10;         //12 , 1
            //}
            //if (number==sum)
            //{
            //    Console.WriteLine("Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Not Polindrome");
            //}


        }

        #endregion

        #region NameFind
        public static int Finds(this string Name, string Find)
        {
            string[] arry = Name.Split(" ");
            int count = 0;
            for (int i = 0; i < arry.Length; i++)
            {
                if (Find == arry[i])
                {
                    count++;
                }

            }
            return count;

        }
        #endregion

    }
}
