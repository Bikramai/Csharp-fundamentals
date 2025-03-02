using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Control_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Type Your Name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }
        }
    }
}
