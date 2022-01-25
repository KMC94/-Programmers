using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution
{
    static void Main(string[] args)
    {

        char test = 'a';
        char test2 = 'A';
        Console.WriteLine(Convert.ToInt32(test) + " " + Convert.ToInt32(test2));

        string testStr = "1zerotwozero3";
        Console.WriteLine(solution(testStr));

        //answer = solution(words);

        //foreach (var item in answer)
        //{
        //    Console.WriteLine(item + " ");
        //}

    }
    public static int solution(string s)
    {
        string answer = null;
        string stringBuilder = null;

        var dic = new Dictionary<string, int>()
        {
            {"zero", 0},
            {"one",  1},
            {"two",  2},
            {"three",3},
            {"four", 4},
            {"five", 5},
            {"six",  6},
            {"seven",7},
            {"eight",8},
            {"nine", 9},
        };

        foreach (var item in s)
        {
            if(item >= 'A') // 'A'는 65, 'a'는 97
            {
                stringBuilder += item;

                if(dic.ContainsKey(stringBuilder))
                {
                    answer += dic[stringBuilder];
                    stringBuilder = null; // Key값을 찾았으면 초기화를 해준다
                }
            }
            else
            {
                answer += item;
            }
        }

        int ans = 0;
        int.TryParse(answer, out ans);

        return ans;
    }
}



    //public int[] solution(string[] id_list, string[] report, int k)
    //{
    //    int[] answer = new int[id_list.Length]; // 결과 배열.

    //    int[] receive = new int[id_list.Length]; // 신고받은 횟수.
    //    int[] send = new int[id_list.Length];    // 신고한 횟수.

    //    report = report.Distinct().ToArray();

    //    // 신고받은 횟수를 기록.
    //    for (int i = 0; i < report.Length; i++)
    //    {
    //        string report_str = report[i].Split(' ')[1];
    //        int report_index = Array.IndexOf(id_list, report_str);
    //        receive[report_index]++;
    //    }

    //    // 신고받은 횟수가 k보다 높을 시 answer 값을 상승.
    //    for (int i = 0; i < report.Length; i++)
    //    {
    //        string report_str = report[i].Split(' ')[1];
    //        int report_index = Array.IndexOf(id_list, report_str);

    //        if (receive[report_index] >= k)
    //        {
    //            string send_str = report[i].Split(' ')[0];
    //            int send_index = Array.IndexOf(id_list, send_str);
    //            answer[send_index]++;
    //        }
    //    }

    //    return answer;
    //}
