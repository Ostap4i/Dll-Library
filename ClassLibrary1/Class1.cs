using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Class1
    {
        public static void Print(Object message)
        {
            Console.WriteLine(message);
        }
    }


    public static class ClassLibrary1
    {
        public static Int32 Max(List<Int32> numbers)
        {
            return numbers.Max();
        }

        public static Int32 Min(List<Int32> numbers)
        {
            return numbers.Min();
        }

        public static Int32 Sum(List<Int32> numbers)
        {
            return numbers.Sum();
        }
    }
}
