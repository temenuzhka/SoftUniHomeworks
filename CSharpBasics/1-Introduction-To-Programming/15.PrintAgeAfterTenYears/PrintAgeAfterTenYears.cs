namespace _15.PrintAgeAfterTenYears
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class PrintAgeAfterTenYears
    {
        static void Main()
        {
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your current age is {0} and after ten years your age will be {1}", age, age + 10);
        }
    }
}
