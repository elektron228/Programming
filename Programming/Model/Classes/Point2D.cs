using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    public class Point2D
    {
        private int _x;
        private  int _y;

        public int X
        {
            get => _x;
            private set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }

        }

        public int Y
        {
            get => _y;
            private set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }
        public Point2D(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
