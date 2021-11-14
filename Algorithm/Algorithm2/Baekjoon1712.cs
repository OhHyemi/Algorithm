using System;

namespace Algorithm2
{
    class Baekjun1712
    {
        static void Main(string[] args)
        {
            //방법 1
            var list = Console.ReadLine()!.Split(' ');
		
            int fix = int.Parse(list[0]);
            int variable = int.Parse(list[1]);
            int price = int.Parse(list[2]);
			
            if(variable >= price)//가변지출이 제품 가격과 같거나 크면 손익이 날 수 없다.
            {
                Console.WriteLine(-1);//-1 출력
                return;
            }
		
            int count = 1;
            int cost = 0;
		
            while(true) //카운트를 1씩 올리면서 손익분기점을 찾는다
            {
                cost = fix + variable * count; //총 비용 = 고정지출 + 가변지출 * 제품 갯수
                if(price * count - cost > 0 )//순 이익 = 제품 가격 * 제품 갯수 - 총 비용
                {
                    break;
                }
			
                count++;
            }

            Console.WriteLine(count);
            
            //방법 2
            // string input = Console.ReadLine();
		          //
            // var list = input.Split(' ');
		          //
            // int fix = int.Parse(list[0]);
            // int variable = int.Parse(list[1]);
            // int price = int.Parse(list[2]);
		          //
            // if(variable >= price)
            // {
            //     Console.WriteLine(-1);
            //     return;
            // }
		          //
            // int count = 1;
            // // 0이 되는 지점 => fix + variable * count = price * count
            // // fix = (price - variable) * count
            // count = fix/(price - variable) + 1;
		          //
            // Console.WriteLine(count);
        }
    }
}