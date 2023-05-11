using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattrin_Udomsomp_Ex01
{
    internal class QuestionBank
    {
        
        char ans1, ans2, ans3, ans4, ans5;

        int correct = 0;
        
        // method to inteact with user
        public void InputAnswer()

        {
            SimulateQuestion();

            
        }

        // method to stimulate questions
        public void SimulateQuestion()
        {


            int question = 0;
            Console.WriteLine(" 1.What is the datatype of 'student' ? a.string b.integer c.char d.byte");
            ans1 = Console.ReadKey().KeyChar;//a
            Console.WriteLine();
            CheckAnswer(question++);
            Console.WriteLine();

            Console.WriteLine(" 2. What is the data which is passed to method? a.parameter b.signal c.argument d.return value");
            ans2 = Console.ReadKey().KeyChar;//c
            Console.WriteLine();
            CheckAnswer(question++);
            Console.WriteLine();

            Console.WriteLine(" 3. What is the command to recieve the string from keyboard in C# a. Console.ReadInt(); b.Console.ReadLine(); c.Console.ReadChar(); d. all are correct");
            ans3 = Console.ReadKey().KeyChar;//b
            Console.WriteLine();
            CheckAnswer(question++);
            Console.WriteLine();
            
            Console.WriteLine(" 4. What is the constructor in class Student a. public student b. public void Student() c.public Student() d. a and c are correct ");
            ans4 = Console.ReadKey().KeyChar;//c
            Console.WriteLine();
            CheckAnswer(question++);
            Console.WriteLine();
            
            Console.WriteLine("5. Which one is correct for  creating array? a. int[] num = {1,a}; b. string num[] = {a,c}; c. int num[] = {1,3}; d.int[] num = {2,9}; ");
            ans5 = Console.ReadKey().KeyChar;//d
            Console.WriteLine(); 
            CheckAnswer(question++);

            // display grade
            Console.WriteLine();
            Console.WriteLine($"you answered {correct} correct(s), that is {correct * 20} %.");



        }


        // method to check answer
         public void CheckAnswer(int question)

        {

            if (question == 0 && ans1.Equals('a'))
            {

                correct++;
                CongratulationMessage();

            }

            else if (question == 1 && ans2.Equals('c'))
            {

                correct++;
                CongratulationMessage();

            }

            else if (question == 2 && ans3.Equals('b'))
            {
                
                correct++;
                CongratulationMessage();

            }

            else if (question == 3 && ans4.Equals('c'))
            {
               
                correct++;
                CongratulationMessage();

            }

            else if (question == 4 && ans5.Equals('d'))
            {
              
                correct++;
                CongratulationMessage();

            }
            else
            {

                IncorrectMessage();

            }


        }


        // method to display a random message "congratulations"
        public static String CongratulationMessage()
        {

            Random rand = new Random();
            int num = rand.Next(1, 4);

            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Exellent!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Good job!");

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Correct!");

                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Nice work!");

                        break;
                    }
            }
            return ("good");
        }
        // method to display message when it is incorrect.
        public String IncorrectMessage()
        {
            Random rand = new Random();
            int number = rand.Next(1, 4);
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Wrong!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Don't give up");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Try once more!");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("No, Heep trying!");
                        break;
                    }
            }
            return ("bad");

        }

    }
}
