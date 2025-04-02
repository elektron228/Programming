using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о точке.
    /// </summary>
    public class Point2D
    {
        private int _x;
        private  int _y;

        /// <summary>
        /// Возвращает значение по <see cref="X"/>.
        /// </summary>
        public int X
        {
            get => _x;
            private set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }

        }

        /// <summary>
        /// Возвращет значение по <see cref="Y"/>.
        /// </summary>
        public int Y
        {
            get => _y;
            private set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
