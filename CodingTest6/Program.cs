﻿namespace CodingTest6
{
    //2024년 08월 05일
    //문제 : 정수 num1과 num2가 매개변수로 주어집니다. 두 수가 같으면 1 다르면 -1을 retrun하도록
    //       solution 함수를 완성해주세요.
    //URL : https://school.programmers.co.kr/learn/courses/30/lessons/120807
    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = 0;
                if (num1 == num2)
                {
                    answer = 1;
                }
                else
                {
                    answer = -1;
                }
                return answer;
            }
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            int a = s.solution(7, 99);
            Console.WriteLine(a);
        }
    }
}
