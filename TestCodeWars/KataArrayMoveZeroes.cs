using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeWars
{
    public class KataArrayMoveZeroes
    {
        public static int[] MoveZeroes(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    continue;
                Array.Copy(arr, i + 1, arr, i, arr.Length - (i + 1));
                arr[arr.Length - 1] = 0;
                if (arr.Skip(i + 1).ToArray().All(x => x == 0))
                    break;

                while (arr[i] == 0)
                    Array.Copy(arr, i + 1, arr, i, arr.Length - (i + 1));
            }
            //shortest version, but (on the forum they say not the fastest)
            //return arr.OrderBy(x => x == 0).ToArray();

            //if in need see the other solutions


            return arr;
        }
    }
}
