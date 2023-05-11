using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Chattrin_Udomsomporn_Ex_02
{
    internal class Lotto
    {

        // instace array hoding 3 values of interger 
        int[] lottoNum = new int[3];
        int sum = 0;

        // constructor of lotto
        public Lotto()
        {
            
            Random rand = new Random();
            int num1 = rand.Next(0, 9);
            int num2 = rand.Next(0, 9);
            int num3 = rand.Next(0, 9);
            lottoNum[0] = num1;
            lottoNum[1] = num2;
            lottoNum[2] = num3;
         
            sum = num1 + num2 + num3;
         }
        
        // method  returning array.
       public int[] myArray()
        {
             
           foreach (int i in lottoNum)
            {
               Console.Write(i+" ");
            }
            return lottoNum;    
            
        } 
        
        //method turn result 
        public int Result()
        {

            return sum;
          

         }
         
        }
    }


