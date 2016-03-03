using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = { 1,2, 3, 4,5,6,7,8,9};
            int[] c = solution(b, 10);
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i] + " _ " + c[i]);
            }
                Console.ReadKey();

        }

        public static int[] solution(int[] A, int K)
        {
            int[] result = new int[A.Length];

            for(int i = 0; i<A.Length; i++)
            {
                int position = i + K;
                while (position >= A.Length)
                {
                    position = position - A.Length;
                }
                result[position] = A[i];

            }
            return result;
        }
    }
}
