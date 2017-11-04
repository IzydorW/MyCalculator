using System;
using System.Collections.Generic;

namespace MyCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
                {
                    Console.WriteLine("Welcome to the calculator. Enter operation on two numbers.");
                    char[] splitSeperators = {'+', '-', '*', '/'};
                    double number1, number2;
                    double result = 0;
                    
                    String line= Console.ReadLine();
                    int position = line.IndexOfAny(splitSeperators);
                    Double.TryParse(line.Substring(0, position),out number1);
                    String sign = line.Substring(position, 1);
                    Double.TryParse(line.Substring(position + 1),out number2);
        
                    switch (sign)
                    {
                        case"+":
                             result = number1 + number2;
                        break;
                        case"-":
                             result = number1 - number2;
                             break;
                        case"*":
                            result = number1 * number2;
                            break;
                        case"/":
                            if(number2 != 0.0)
                            result = number1 / number2;
                            else
                            {
                                Console.WriteLine("Denominator=0. Dividing by 0 is forbidden.");
                            }
                            break;    
                        default:
                            Console.WriteLine("Something is no yes... Input is not a mathematical expression.");
                            break;
                    }
                    Console.WriteLine("Result is: "+result);
                    Console.ReadLine();
                }
    }
}