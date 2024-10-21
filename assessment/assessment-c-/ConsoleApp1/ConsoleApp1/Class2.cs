using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
public class Grade
{
    private List<int> grades = new List<int>();

    static void Main(string[] args)
    {
        Grade grade = new Grade();
        grade.Management();
    }

    public void Management()
    {
        Console.WriteLine("Grade valuation");
        while (true)
        {
            Console.WriteLine("Enter a grade(0-100):");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid Input, please enter a number between 0-100");

                if (grades.Count >= 50)
                {
                    Console.WriteLine("Pass");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
                if (grades.Count > 0)
                {
                    int highest = grades.Max();
                    Console.WriteLine("Highest" + highest);

                    int lowest = grades.Min();
                    Console.WriteLine("Lowest" + lowest);
                }

            }
        }
    }

}
}
