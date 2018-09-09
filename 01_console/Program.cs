using System;
using System.Collections;
using System.Collections.Generic;

namespace _01_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PnP.NET Lab 01 (1)");
            Console.WriteLine();

            List<double> arrayOfX = new List<double>();
            List<double> arrayOfY = new List<double>();

            Console.WriteLine("Enter numbers (For example, x.xx, y.yy):");
            while(true) {
              string userInput = Console.ReadLine();
              
              if(userInput.Length <= 0) {
                break;
              }

              userInput = userInput.Replace(" ", "");
              string[] numbers = userInput.Split(",");
              
              try {
                double first = Convert.ToDouble(numbers[0]);
                arrayOfX.Add(first);
              } catch(Exception err) {
                Console.WriteLine($"Program.ERRORS.ERROR:: {err}");
                break;
              }

              try {
                double second = Convert.ToDouble(numbers[1]);
                arrayOfY.Add(second);
              } catch(Exception err) {
                Console.WriteLine($"Program.ERRORS.ERROR:: {err}");
                break;
              }
            }

            for(int i = 0; i < arrayOfX.Count; i++) {
              Console.WriteLine($"X: {arrayOfX[i]}, Y: {arrayOfY[i]}");
            }
        }
    }
}
