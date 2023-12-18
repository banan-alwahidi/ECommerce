using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Calculator
{
    static void Main()
    {

        Console.WriteLine("mathematical calculations");
        Console.Write("Enter your first numbre: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your secand numbre: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter op  (+, -, *, /, %): ");
        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
            case "%":
                result = num1 % num2;
                break;
            default:
                Console.WriteLine("Dose not exsist!");
                break;


        }
        Console.WriteLine("result: " + result);


        Console.WriteLine("Conversion system");
       
        Console.Write("Enter number : ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose the operation you want to perform:");
        Console.WriteLine("1. Convert to system (hexadecimal)");
        Console.WriteLine("2. Convert to system (decimal)");
        Console.WriteLine("3. Convert to system (octal)");
        Console.WriteLine("4. Convert to system (binary)");

        int choice = Convert.ToInt32(Console.ReadLine());

        string result1 = "";

        switch (choice)
        {
            case 1:
                result1 = Convert.ToString(number, 16);
                break;
            case 2:
                result1 = Convert.ToString(number, 10);
                break;
            case 3:
                result1 = Convert.ToString(number, 8);
                break;
            case 4:
                result1 = Convert.ToString(number, 2);
                break;
            default:
                Console.WriteLine("Dose not exsist!");
                break;
        }
        Console.WriteLine("result: " + result);

        Console.WriteLine("account Trigonometric fun !");

        Console.Write("Enter number1: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose the transaction number you wish to perform:");
        Console.WriteLine("1.(tan)");
        Console.WriteLine("2.(cos)");
        Console.WriteLine("3.(sin)");
        Console.WriteLine("4.(log)");

        int Trigonometric  = Convert.ToInt32(Console.ReadLine());

        double result2 = 0;

        switch (Trigonometric )
        {
            case 1:
                result2 = Math.Tan(number);
                break;
            case 2:
                result2 = Math.Cos(number);
                break;
            case 3:
                result2 = Math.Sin(number);
                break;
            case 4:
                result2 = Math.Log(number);
                break;
            default:
                Console.WriteLine("Dose not exsist!");
                break;
        }

        Console.WriteLine("result: " + result2);
       

        
            Console.WriteLine("Enter the temperature in Celsius:");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
            Console.WriteLine($"Temperature in Kelvin: {kelvin}");

            Console.WriteLine("أEnter the number to calculate factorial:");
            int number3 = int.Parse(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"the number the multiplication factor {number} : {factorial}");

            Console.ReadLine();
            Console.ReadKey();
        }
    }

    
    

   
    



    

