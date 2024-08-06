namespace CodingTest7
{
    //2024년 08월 05일
    //문제 : 첫 번째 분수의 분자와 분모를 뜻하는 numer1, denom1, 두 번째 분수의 분자와 분모를 뜻하는
    //       numer2, denom2가 매개변수로 주어집니다. 두 분수를 더한 값을 기약 분수로 나타냈을 때
    //       분자와 분모를 순서대로 담은 배열을 return 하도록 solution 함수를 완성해보세요.
    //URL : https://school.programmers.co.kr/learn/courses/30/lessons/120808

    internal class Program
    {
        public class Solution
        {
            public int[] solution(int numer1, int denom1, int numer2, int denom2)
            {
                // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
                int denom = denom1 * denom2; //분자 구하기
                int numer = numer1 * denom2 + numer2 * denom1;      //분모 구하기

                int gcd = GCD(numer, denom);

                int[] sum = new int[2];
                sum[0] = numer / gcd;
                sum[1] = denom / gcd;

                return sum;
            }
        }
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] a= s.solution(9, 2, 1, 3);
            Console.WriteLine($"{a[0]}, {a[1]}");
        }
    }
}
