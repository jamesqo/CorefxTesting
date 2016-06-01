using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tuple = ValueTuple.Create(int.MinValue, ~1);
            Console.WriteLine(tuple.GetHashCode());
        }
    }
}
