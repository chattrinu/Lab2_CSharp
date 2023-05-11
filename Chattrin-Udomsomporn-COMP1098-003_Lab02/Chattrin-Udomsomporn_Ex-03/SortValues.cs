using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattrin_Udomsomporn_Ex_03
{
    internal class SortValues
    {
        
      // method to reverse and sort numbers
        public static void SortNumbers(int n1,int n2,int n3,int n4,int n5,int n6)
        {
            int[] numbers = new int[6];
            numbers[0] = n1;
            numbers[1] = n2;
            numbers[2] = n3;
            numbers[3] = n4;
            numbers[4] = n5;
            numbers[5] = n6;
            Array.Sort(numbers);  // sort numbers ascending numbers
            Array.Reverse(numbers); // reverse to decending numbers
            foreach (int i in numbers)

            {
                Console.Write(i+" ");
            }
            
        }
    }
}
