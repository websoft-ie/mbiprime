using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MBIPrimaryTest.Models
{
    public static class Util
    {
        public static string GetPrimesUpTo(int max)
        {
            List<int> result = new List<int>();

            for (int i = 2; i <= max; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    result.Add(i);
            }

            return String.Join(", ", result);
        }
    }
}