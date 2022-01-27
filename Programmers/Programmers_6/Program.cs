using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 내적 (https://programmers.co.kr/learn/courses/30/lessons/70128?language=csharp)
namespace Programmers_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            int[] b = new int[] { -3, -1, 0, 2 };

            Console.WriteLine(solution(a, b));
        }

        public static int solution(int[] a, int[] b)
        {
            int answer = 0;

            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }

            // Linq
            a.Zip(b, (t1, t2) => t1 * t2).Sum();

            return answer;
        }
    }
}
