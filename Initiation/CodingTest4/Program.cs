﻿namespace CodingTest4
{
    //2024년 08월 05일
    //문제 : 정수 num1, num2가 매개변수로 주어질 때, num1을 num2로 나눈 몫을 return 하도록 solution 함수를 완성해주세요.
    //URL : https://school.programmers.co.kr/learn/courses/30/lessons/120805

    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = num1 / num2;
                return answer;
            }
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            int a = s.solution(7, 2);
            Console.WriteLine(a);
        }
    }
}
