using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really long text.";
            var summary = Control_Flow.StringUtility.SummarizeText(sentence, 40);
            Console.WriteLine(summary);
            
        }

        
    }
}
