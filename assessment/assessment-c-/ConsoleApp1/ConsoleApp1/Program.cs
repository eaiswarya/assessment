using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
public class Calculator {
public int Divide(int a,int b)
{
    Console.WriteLine("Dividing {a} by {b}");
    if (b == 0)
    {
        throw new DivideByZeroException("you cant divide by zero");
    }
    return a / b;
}

public void ProcessNumbers(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("given array cant be empty or null");
    }
        Console.WriteLine("Processing {numbers.length} numbers");
        for (int i = 0; i <= numbers.Length; i++)
    {
        var result = Divide(numbers[i], 2);
        Console.WriteLine("Result for index{i}: " + result);
    }
        Console.WriteLine("Finished the processing");
}
} 
}
