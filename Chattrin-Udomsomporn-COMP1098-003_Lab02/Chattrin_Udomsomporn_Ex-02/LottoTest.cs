using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chattrin_Udomsomporn_Ex_02
{
    internal class LottoTest
    {
        static void Main(string[] args)
        {

            Lotto lotto = new Lotto();

            // random the lottonumber
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Choose a number form 1-27");
                int guessNum = int.Parse(Console.ReadLine());
                Console.WriteLine($"your choosen number is {guessNum}");
               
                
                if (guessNum == lotto.Result())
                {
                    Console.WriteLine("You win!!");
                    Console.WriteLine($"This is result:{lotto.Result()}");
                    Console.WriteLine();
                    Console.WriteLine(lotto.myArray());
                    break;

                }
                else
                {
                    Console.WriteLine("Try again");
                    
                }
                
                Console.WriteLine();

            }
            // display result
            Console.WriteLine($"This is result:{lotto.Result()}");
            Console.WriteLine();
            Console.WriteLine(lotto.myArray());
            Console.WriteLine();
        }
    }
 }

