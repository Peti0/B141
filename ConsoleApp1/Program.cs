using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - két szám bekérése és összeadása
            int szamA;
            int szamB;
            Console.WriteLine("Adja meg az első számot!");
            szamA = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a második számot!");
            szamB = int.Parse(Console.ReadLine());
            Console.WriteLine("A két szám összege:" + (szamA+szamB).ToString());
            
            Console.ReadLine();
        }
        
    }
}
