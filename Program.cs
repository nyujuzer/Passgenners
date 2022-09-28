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
            Console.Write("Hány karakteres legyen a jelszavad?");
            string len = Console.ReadLine();
            int length = System.Convert.ToInt32(len);
            char[] abc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] ABC = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] specs = { "!", "@", "{", "}", "?"};
            List<object> pw = new List<object>();
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                int randomChoice = rnd.Next(0, length);
                int chance = rnd.Next(1, 4);
                switch (chance)
                {
                    case 1:
                        pw.Add(abc[randomChoice]);
                        break;
                    case 2:
                        pw.Add(ABC[randomChoice]);
                        break;
                    case 3:
                        pw.Add(nums[randomChoice]);
                        break;
                    case 4:
                        pw.Add(specs[randomChoice]);
                        break;
                    default:
                        break;
                }
            }
            
            
            pw.ForEach(i =>Console.Write(i));
            Console.ReadKey();
        }
    }
}
