// See https://aka.ms/new-console-template for more information
using System;
namespace Sudungtoantu
{

    class Program
    {
        static void Main(string[] arg)
        {
            float width;
            float height;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());

            float area = width * height;
            Console.WriteLine("S chu nhat: " + area);
        }
    }
}

