using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystem
{
    public static class Validator
    {
        /// <summary>
        /// Проверяет, является ли переданное значение положительным.
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Значение числа не может быть отрицательным.", nameof(value));
            }
        }

        /// <summary>
        /// Проверяет длину строки.
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnStringLength(string value)
        {
            if (value.Length > 100)
            {
                throw new ArgumentException();
            }
        }
    }
}
