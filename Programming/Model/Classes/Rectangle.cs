using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    public class Rectangle
    {
        private Double _length;
        private Double _wide;
        private string _colour;
        
        /// <summary>
        /// Возвращает и задает длину. Должно быть не меньше нуля.
        /// </summary>
        public Double Length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину. Должно быть не меньше нуля.
        /// </summary>
        public Double Wide
        {
            get { return _wide; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _wide = value;
            }
        }

        /// <summary>
        /// Возращает и задает цвет.
        /// </summary>
        public string Colour { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина.</param>
        /// <param name="wide">Ширина.</param>
        /// <param name="colour">Цвет.</param>
        public Rectangle(Double length, Double wide, string colour)
        {
            Length = length;
            Wide = wide; 
            Colour = colour;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle() { }
    }
}
