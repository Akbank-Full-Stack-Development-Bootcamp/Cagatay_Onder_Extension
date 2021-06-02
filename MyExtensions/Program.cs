using MyExtensions.Extensions;
using System;

namespace MyExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1994, 06, 20);
            int days = date.CalculateDays();
            Console.WriteLine( days +" gündür hayattasın :)");
        }
    }
}
