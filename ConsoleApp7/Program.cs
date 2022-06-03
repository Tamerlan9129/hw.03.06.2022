using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tamerlan";
            int Age = 30;
            AllData(name);
            AllData(Age);
            
        }
        static void AllData(object a) 
        {
            Console.WriteLine(a);
        
        }
    }
}
