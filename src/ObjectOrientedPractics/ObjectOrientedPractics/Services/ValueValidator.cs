using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит методы для валидации значений.
    /// </summary>
    static class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="maxLenght">Максимальная длина строки.</param>
        /// <param name="propertyName">Название свойства, вызвавшего метод.</param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertStringOnLength (string value, int maxLenght, string propertyName)
        {
            if (value.Length > maxLenght)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLenght} символов.");
            }
        }

    }
}
