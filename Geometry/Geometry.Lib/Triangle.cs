using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Lib
{
    public class Triangle
    {
        private int _s1;
        private int _s2;
        private int _s3;

        public Triangle(int v1, int v2, int v3)
        {
            _s1 = v1;
            _s2 = v2;
            _s3 = v3;
        }

        public bool IsValid 
        {
            get
            {
                if (_s1 >= _s2 + _s3 || _s2 > _s1 + _s3 || _s3 >= _s1 + _s2) return false;
                return true;
            }
        }
        public bool IsRightAngled { 
        get
            {
                return SumOfSquares(_s1, _s2, _s3) || SumOfSquares(_s2, _s3, _s1) || SumOfSquares(_s3, _s1, _s2);
            }
        }

        bool SumOfSquares(int a, int b, int c)
        {
            return a * a == b * b + c * c;
        }
    }
}
