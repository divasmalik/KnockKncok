using System;

namespace KnockKnock.Helpers
{
    public class CalculateFab
    {

        private readonly Int64 maxLimit = 92;

        public bool IsInLimit(Int64 n)
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

        public Int64 GetNthFibonacci(Int64 n)
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

        private Int64 CalculateNthFibonaci(Int64 n)
        {
            double sqrt5 = Math.Sqrt(5);
            double posPhi = (sqrt5 + 1) / 2;
            //double negPhi = (1 - sqrt5) / 2;
            //var result = ((Math.Pow(posPhi, n) - (Math.Pow(negPhi, n))) / sqrt5);
            //var res = Math.Round(result);
            var i = Math.Abs(n);
            var res = Math.Pow(posPhi, i)/ sqrt5;
            return (long)res;
        }
        
    }
}