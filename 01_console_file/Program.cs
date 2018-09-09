using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _01_console_file
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("PnP.NET Lab 01 (2)");
      Console.WriteLine();
      Console.Write("Please, enter file name: ");

      string fileName = Console.ReadLine();
      
      StreamReader file = new StreamReader($"{fileName}");

      List<double> arrayOfX = new List<double>();
      List<double> arrayOfY = new List<double>();

      string userInput;

      while((userInput = file.ReadLine()) != null) {
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

      file.Close();

      for(int i = 0; i < arrayOfX.Count; i++) {
        Console.WriteLine($"X: {arrayOfX[i]}, Y: {arrayOfY[i]}");
      }

    }
  }
}
