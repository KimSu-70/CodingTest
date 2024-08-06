namespace CodingTest5
{
    //2024년 08월 05일
    //문제 : 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에 1,000을 곱한 후
    //      정수 부분을 return 하도록 soltuion 함수를 완성해주세요.
    //URL : https://school.programmers.co.kr/learn/courses/30/lessons/120806

    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                float tmd = ((float)num1 / num2) * 1000;
                int answer = (int)tmd;
                return answer;
            }
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            int a = s.solution(1, 16);
            Console.WriteLine(a);
        }
    }
}
