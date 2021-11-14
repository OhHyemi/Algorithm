using System;

namespace Algorithm4
{
    class Baekjun11720
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine()!); //입력받아 int로 전환 
            string nums = Console.ReadLine(); //공백없이 숫자 입력
		
            int result = 0;
			
            foreach(var item in nums)//item : char
            {
                //변환된 값을 더하기.
                result += int.Parse(item.ToString());//char->string->int 
            }
		
            Console.WriteLine(result);	
        }
    }
}