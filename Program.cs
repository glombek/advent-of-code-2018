using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new System.Net.WebClient();
            var input = client.DownloadString("https://gist.githubusercontent.com/glombek/9d95ddc3054bece25b19d236dc00d861/raw/b6a9da388e7e3e371415f0791055a905b94a397e/sample");

            string[] lines = input.Split('\n');

            int total = 0;

            foreach (string line in lines)
            {
                int number = int.Parse(line);
                total = total + number;
                Console.WriteLine(line);
            }

            Console.WriteLine("The total is: " + total);
            Console.ReadLine();
        }
    }
}
