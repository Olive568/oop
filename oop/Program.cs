using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            
            while (cont)
            {
                Console.WriteLine("A : addition");
                Console.WriteLine("B : subtraction");
                Console.WriteLine("C : multiplication");
                Console.WriteLine("D : division");
                Console.WriteLine("E : remainder");
                Console.Write(": ");
                string option = Console.ReadLine();
                option = option.ToUpper();
                switch (option)
                {
                    case "A":
                        add();
                        break;
                    case "B":
                        sub();
                        break;
                    case "C":
                        mul();
                        break;
                    case "D":
                        div();
                        break;
                    case "E":
                        rem();
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("do you wish to continue? y/n");
                string choice2 = Console.ReadLine();
                choice2 = choice2.ToLower();
                if(choice2 == "y")
                {
                    cont = true;
                    Console.Clear();
                }
                else if(choice2 == "n")
                {
                    cont = false;
                }
                
            
            }
        }
        static void add()
        {
            Console.WriteLine("write the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("write the second number");
            int b = int.Parse(Console.ReadLine());
            Console.Write(a + " + " + b + " = ");
            Console.Write(a + b);
           
        }
        static void sub()
        {
            Console.WriteLine("write the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("write the second number");
            int b = int.Parse(Console.ReadLine());
            Console.Write(a + " - " + b + " = ");
            Console.Write(a - b);
        }

        static void mul()
        {
            Console.WriteLine("write the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("write the second number");
            int b = int.Parse(Console.ReadLine());
            Console.Write(a + " x " + b + " = ");
            Console.Write(a * b);
        }

        static void div()
        {
            Console.WriteLine("write the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("write the second number");
            int b = int.Parse(Console.ReadLine());
            Console.Write(a + " / " + b + " = ");
            Console.Write(a / b);
        }
        static void rem()
        {
            Console.WriteLine("write the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("write the second number");
            int b = int.Parse(Console.ReadLine());
            Console.Write(a + " % " + b + " = ");
            Console.Write(a % b);
        }



    }
}

