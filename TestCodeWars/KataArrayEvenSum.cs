using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataArrayEvenSum
    {
        public static int FindEvenIndex(int[] arr)
        {
            //Code goes here!

            //first solution that comes to mind

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int num1 = 0, num2 = 0;
            //    if (i == 0)
            //        num1 = 0;
            //    else
            //    {
            //        for (int j = 0; j < i; j++)
            //        {
            //            num1 += arr[j];
            //        }
            //    }

            //    if (i == arr.Length)
            //        num2 = arr[arr.Length - 1];
            //    else
            //    {
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            num2 += arr[j];
            //        }
            //    }
            //    if (num1 == num2)
            //        return i;
            //}

            //second solution searching the internet, both work

            for (int i = 0; i < arr.Length; i++)
            {
                var firstHalf = arr.Take(i).ToArray();
                var secondHalf = arr.Skip(i+1).ToArray();
                if(firstHalf.Sum() == secondHalf.Sum())
                    return i;
            }


            return -1;
        }
    }
}
