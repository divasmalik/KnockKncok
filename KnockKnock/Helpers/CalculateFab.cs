using System;

namespace KnockKnock.Helpers
{
    public static class CalculateFab
    {

        private static readonly Int64 maxLimit = 92;

        public static bool IsInLimit(Int64 n)
        {
            if (n > maxLimit || n < -maxLimit)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Int64 GetNthFibonacci(Int64 n)
        {
            if (!IsInLimit(n))
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                var res = CalculateNthFibonaci(n);
                if(n<0 && n%2==0)
                {
                    res = -res;
                }
                return res;
            }
            
        }

        private static Int64 CalculateNthFibonaci(Int64 n)
        {
            double sqrt5 = Math.Sqrt(5);
            double Phi = (sqrt5 + 1) / 2;
            var i = Math.Abs(n);
            var res = Math.Pow(Phi, i)/ sqrt5;
            return (long)res;
        }
        
    }
}