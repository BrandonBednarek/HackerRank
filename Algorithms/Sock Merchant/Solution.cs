// Problem: https://www.hackerrank.com/challenges/sock-merchant

using System;

namespace Sock_Merchant
{
    class Solution
    {
        // Complete the sockMerchant function below.
        static int SockMerchant(int n, int[] ar)
        {
            int matches = 0;
            Array.Sort(ar);

            for (int i = 0; i < n - 1; i++)
            {
                if (ar[i] == ar[i + 1])
                {
                    matches += 1;
                    i++;
                }
            }
            return matches;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = SockMerchant(n, ar);

            Console.WriteLine(result);
        }
    }
}
