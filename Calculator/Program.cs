using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("********************");
                Console.WriteLine("CALCULATOR PROGRAM");
                Console.WriteLine("********************");
            string choice;
            string sign;
            do
            {
                
                Console.Write("Enter your fist digit: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your second digit: ");
                double b = Convert.ToDouble(Console.ReadLine());
                sign="";

                Console.Write("Enter operation: ");
                sign = Console.ReadLine();
                double result = 0;
                
                switch (sign)
                {
                    case "+":
                        result=a+b;
                        Console.WriteLine(a+"+"+b+"="+result);
                        break;
                    case "-":
                        result=a-b;
                        Console.WriteLine(a+"-"+b+"="+result);
                        break;
                    case "*":
                        result=a*b;
                        Console.WriteLine(a+"*"+b+"="+result);
                        break;
                    case "/":
                        if (b!=0)
                        {
                            result=a/b;
                            Console.WriteLine(a+"/"+b+"="+result);
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is invalid. Close the terminal and try again!");
                        }
                        break;
                    case "%":
                        result=a%b;
                        Console.WriteLine(a+"%"+b+"="+result);
                        break;
                    default:
                        Console.WriteLine("Not a valid operator. Close terminal and try again.");
                        break;
                }
                Console.Write("Do you wish to continue? Yes/No: ");
                choice = Console.ReadLine();
                choice=choice.ToUpper();
            } while (choice=="YES");
            Console.WriteLine("Sayonara!!");

           Console.ReadLine();
        }
    }
}
