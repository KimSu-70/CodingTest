namespace CodingTest2
{
    //2024년 08월 05일
    //문제 : 정수 num1과 num2가 주어질 때, num1에서 num2를 뺀 값을 return하도록 soltuion 함수를 완성해주세요.
    //URL : https://school.programmers.co.kr/learn/courses/30/lessons/120803

    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = num1 - num2;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int a = s.solution(100, 2);
            Console.WriteLine(a);
        }
    }
}
