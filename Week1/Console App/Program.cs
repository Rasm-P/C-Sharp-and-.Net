using System;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            double result;

            Console.WriteLine("Use this calculator to calculate +,-,/,*");
            Console.WriteLine("Type 'stop' when you want to exit.");

            while (true) {
                line = Console.ReadLine();

                if (line.Equals("stop"))
                {
                    break;
                }

                try
                {
                    if (line.Contains("+"))
                    {
                        String[] stringArr = line.Split("+");
                        result = double.Parse(stringArr[0]) + double.Parse(stringArr[1]);
                        Console.WriteLine(stringArr[0] + "+" + stringArr[1] + " = " + result);
                    } 
                    else if (line.Contains("-"))
                    {
                        String[] stringArr = line.Split("-");
                        result = double.Parse(stringArr[0]) - double.Parse(stringArr[1]);
                        Console.WriteLine(stringArr[0] + "-" + stringArr[1] + " = " + result);
                    }
                    else if (line.Contains("/"))
                    {
                        String[] stringArr = line.Split("/");
                        result = double.Parse(stringArr[0]) / double.Parse(stringArr[1]);
                        Console.WriteLine(stringArr[0] + "/" + stringArr[1] + " = " + result);
                    }
                    else if (line.Contains("*"))
                    {
                        String[] stringArr = line.Split("*");
                        result = double.Parse(stringArr[0]) * double.Parse(stringArr[1]);
                        Console.WriteLine(stringArr[0] + "*" + stringArr[1] + " = " + result);
                    }
                } 
                catch
                {
                    Console.WriteLine("Your input " + line + " could not be calcualted.");
                }

            };
        }
    }
}
