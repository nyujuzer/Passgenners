using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0928
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> abc = new ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
            ABC = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']
            nums = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
            specs = ["!", "@", "{", "}", "?"]
            List<object> name = new List<object>();
            name.Add("Hello World");
            name.Add(1);
            name.ForEach(i =>Console.WriteLine("{0}\t",i));
            Console.ReadKey();
        }
    }
}
