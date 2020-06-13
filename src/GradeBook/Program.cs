using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Thomaz's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.GetStatistcs();    // colocando a variavel pora puxar o codigo do GetStatics

            Console.WriteLine($"Sua menor nota é {stats.Low}");
            Console.WriteLine($"Sua maior nota é {stats.High}");
            Console.WriteLine($"Sua nota media é de {stats.Average:N1}");
        }

    }
}