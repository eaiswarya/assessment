using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
public class Employee
{
    static void Main(string[] args)
    {
        Console.WriteLine("Employee pay calc");
        Console.WriteLine("Enter Hourly rate:");
            
        var hourlyRate = Convert.ToDouble(Console.ReadLine());
        if (hourlyRate < 0)
            throw new ArgumentException("it cant be null or zero");

        Console.WriteLine("Enter hours worked:");
            
        var hoursWorked = Convert.ToDouble(Console.ReadLine());
        if (hoursWorked < 0)
            throw new ArgumentException("please input a valid digit");
        var regularPay = Math.Min(hoursWorked, 40) * hourlyRate;
        var overTime = Math.Max(0, hoursWorked - 40) * hourlyRate * 1.5;
        var gross = regularPay + overTime;
        Console.WriteLine("grossPay:" + gross);

        var tax = gross * 0.2;
        double netPay = gross - tax;
        Console.WriteLine("tax:" + tax);
            Console.WriteLine("netPay:"+netPay);


    }
}
}
