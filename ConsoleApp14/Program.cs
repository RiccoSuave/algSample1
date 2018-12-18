using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArry = new int[] { 1, 3, 6, 4, 1, 2 };
            int result = solution(myArry);
            Console.WriteLine("This is the result: {0}", result);
            Console.ReadLine();
        }
        public static int solution (int [] A)
        {
            int result = 0;
            Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i++] != A[i]++) {
                    result = A[i++];
                    result++;
                    return result;
                }
                   
            }
            return A[0];
        }
    }
}
