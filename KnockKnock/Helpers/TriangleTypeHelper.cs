using KnockKnock.Enums;

namespace KnockKnock.Helpers
{
    public class TriangleTypeHelper
    {

        public Type GetTriangleType(int a, int b, int c)
        {
            var type = Type.nonExistant;

            if (!IsValidTriangle(a,b,c)) { return Type.nonExistant; };

            if (IsEquilateral(a, b, c)) { return  Type.Equilateral; };

            if (IsIssoceles(a, b, c)) { return Type.Isosceles; };

            if (IsScalene(a, b, c)) {return Type.Scalene; };

            return type;
        }
        private bool IsValidTriangle(int a, int b, int c)
        {
            if ((a <= 0 || b <= 0 || c <= 0)|| (a + b <= c || b + c <= a || a + c <= b))
            {
                return false;
            }
            return true;
        }

        private bool IsEquilateral(int a,int b,int c)
        {
            if (a == b && b == c)
            {
                return true;
            }
            return false;
        }

        private bool IsIssoceles(int a, int b, int c)
        {
            if (a == b || b == c || a == c)
            {
                return true;
            }
            return false;
        }

        private bool IsScalene(int a, int b, int c)
        {
            if (a != b && a != c && b != c)
            {
                return true;
            }
            return false;
        }
    }
}