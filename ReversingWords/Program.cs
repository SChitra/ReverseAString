using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Cat hat";
            string reversed = Reverse(str);
            Console.WriteLine(reversed);
            string temp = " ";
            foreach (var s in reversed.Split(' '))
            {

                temp = temp + Reverse(s);
            }
            
            Console.WriteLine(temp);
        }

        public static string Reverse(string str)
        {
            string revString = " ";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revString = revString + str[i];
            }
            return revString;
        }
    }
}
