using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Содержит методы для проверки значений на соответсвие условиям.
    /// </summary>
    static class Validator
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
        /// Проверяет, является ли переданное значение положительным.
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(Double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Значение числа не может быть отрицательным.", nameof(value));
            }
            
        }

        /// <summary>
        /// Проверяет, содержится ли переденное значение в заданном диапазоне.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(int value, int min, int max)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException("Значение не входит в диапазон.", nameof(value));
            }
        }

        /// <summary>
        /// Проверяет, содержится ли переденное значение в заданном диапазоне.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(Double value, Double min, Double max)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException("Значение не входит в диапазон.", nameof(value));
            }
        }

        /// <summary>
        /// Проверяет, больше ли первое значение, чем второе.
        /// </summary>
        /// <param name="firstValue">Проверяемое значение.</param>
        /// <param name="secondValue">Значение, с которым сравниваем.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueIsMore(Double firstValue, Double secondValue)
        {
            if (firstValue < secondValue)
            {
                throw new ArgumentException();
            }
        }

    }
}
