﻿namespace CodingTest1
{
    //2024년 08월 05일
    //문제 : 정수 num1과 num2가 주어질 때, num1과 num2의 합을 return하도록 soltuion 함수를 완성해주세요.
    //URL : https://school.programmers.co.kr/learn/courses/30/lessons/120802

    public class CodingTest1
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = num1 + num2;
                return answer;
            }
        }
        public static void Main(string[] args)
        {
            Solution s = new Solution();
            int a = s.solution(5, 8);
            Console.WriteLine(a);
        }
    }
}
