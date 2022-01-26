using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 음양 더하기(https://programmers.co.kr/learn/courses/30/lessons/76501)
namespace Programmers_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] absolutes = new int[3] { 4, 7, 12 };
            bool[] signs = new bool[3] { true, false, true };

            Console.WriteLine(solution(absolutes, signs));
        }

        public static int solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;
            // 부호 정해주기
            for (int i = 0; i < absolutes.Length; i++)
            {
                if(signs[i] == false)
                {
                    absolutes[i] *= -1;
                }
            }

            for(int i = 0; i < absolutes.Length; i++)
            {
                answer += absolutes[i];
            }

            return answer;
        }
    }
}
