using Microsoft.Extensions.DependencyInjection;
using System;
using test.application.Services;
using test.application.Services.Interfaces;
namespace test.consoleApp
{
    /// <summary>
    /// Sample console app to show the execution of ReArraneString Method
    /// </summary>
    class Program
    {
        /// <summary>
        /// To keep this higer class indepentent of low level moduls, its implementd using dependency injection
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IStringAnalyzer, StringAnalyzer>()
                .BuildServiceProvider();
            string[] individuals = { "Sonia", "Maria", "Wood", "Dempster" };
            string[] order = { "4", "1", "2", "3" };
            //string[] order = { "4", "1", "2"};

            var x = serviceProvider.GetService<IStringAnalyzer>();
            try
            {
                string[] reOrderedString = x.ReArrangeString(individuals, order);
                Console.WriteLine("Rearranged elements");
                foreach (string element in reOrderedString)
                {
                    Console.WriteLine(element);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
