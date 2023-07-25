using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    public class LinearSearch
    {
        public static void Main()
        {
            int[] arr = { 10, 30, 12, 11, 323, 345, 566 };
            int target = -1;
            // int ans = Linearsearch(arr, target);
            int[,] arr2D = new int[,] {  { 1, 2, 3 }, { 4, 5, 6 } ,
                                  { 7, 8, 9 }, { 10, 11, 12 }  };
            int[] ans = LinearSearch2D(arr2D, target);
            foreach(int i in ans)
            {
                Console.WriteLine(i);
            }
          
            Console.ReadLine();
        }
        static int[] LinearSearch2D(int[,] arr, int target)
        {
           for(int row=0;row< arr.GetLength(0); row++)
            {
                for(int col = 0; col < arr.GetLength(1);col++)
                {
                    if (arr[row,col]==target)
                    {
                        return new int[] { row, col };
                    }
                }          
            }
            return  new int[] { -1, -1 };
        }
        static int Linearsearch(int[] arr , int target)
        {
            foreach(int i in arr)
            {
                if(target== i)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
