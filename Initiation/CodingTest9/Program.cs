﻿namespace CodingTest9
{
    //2024년 08월 06일
    //문제 : 정수 num1, num2가 매개변수로 주어질 때, num1를 num2로 나눈 나머지를
    //       return 하도록 solution 함수를 완성해주세요.
    //URL : https://school.programmers.co.kr/learn/courses/30/lessons/120810

    public class Solution
    {
        public int solution(int num1, int num2)
        {
            int answer = num1 % num2;
            return answer;
        }
    
    static void Main(string[] args)
        {
            Solution s = new Solution();
            int a = s.solution(3, 2);
            Console.WriteLine(a);
        }
    }
}