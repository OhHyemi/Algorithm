using System;

namespace Algorithm3
{
    class Baekjun1439
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine();

            int count_zero = 0;//0이 쓰여진 카드 그룹의 갯수 (1 이 나오기 전까지의 카드 그룹) 
            int count_one = 0;//1 이 쓰여진 카드 그룹의 갯수 (0 이 나오기 전까지의 카드 그룹) 
		
            for(int i = 0; i < list.Length - 1; ++i)
            {
                if(list[i] != list[i + 1]) //다음 카드와 비교했을 때 서로 다른 카드일 경우
                {	
                    if(list[i] == '0')
                    {
                        if(count_zero == 0 && count_one == 0)//맨 처음 분기점 일 경우
                        {
                            count_one++;//그룹이 하나 생성
                        }
                        count_zero++;//그룹 생성
                    }
                    else if(list[i] == '1')
                    {
                        if(count_zero == 0 && count_one == 0)
                        {
                            count_zero++;
                        }
                        count_one++;
                    }
                }
            }
				
            var result = Math.Min(count_zero, count_one); //더 작은 값을 출력
					
            Console.WriteLine(result);	
        }
    }
}