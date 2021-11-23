using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm13
{
    class Baekjoon2941
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z="};

            var input = new StringBuilder(Console.ReadLine());

            foreach (var s in list)
            {
                input.Replace(s, "*");//해당되는 문자열을 다른 문자로 변경
            }
            Console.WriteLine(input.Length);
        }
        
    }
}