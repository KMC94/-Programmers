using System;

// 없는 숫자 더하기 (https://programmers.co.kr/learn/courses/30/lessons/86051?language=csharp)
namespace Programmers_4
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 8, 4, 0, 6, 7, 9 };

            Console.WriteLine(solution(numbers)); 
        }

        public static int solution(int[] numbers)
        {
            int total = 0;

            // Numbers의 합을 담을 변수
            int sumNumbers = 0;

            // 0 ~ 9 합계구하기
            for (int i = 0; i < 10; i++)
            {
                total += i;
            }

            // 0 ~ 9 숫자가 있나 판단
            for (int i = 0; i < numbers.Length; i++)
            {
                sumNumbers += numbers[i];
            }
            

            return total - sumNumbers;
        }
    }
}
