using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о прямоугольниках.
    /// </summary>
    public class Rectangle
    {
        private Double _length;
        private Double _wide;
        private string _colour;
        private int _centerX;
        private int _centerY;
        private int _id;
        private static int _allRectangelsCount = 0;
        Random rand = new Random();
        
        /// <summary>
        /// Возвращает центр прямоугольника.
        /// </summary>
        public Point2D Center {  get;private set; }

        /// <summary>
        /// Возвращает и задает длину. Должно быть не меньше нуля.
        /// </summary>
        public Double Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                Validator.AssertValueInRange(value, 0, 50);
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
                Validator.AssertOnPositiveValue(value);
                Validator.AssertValueInRange(value, 0, 50);
                _wide = value;
            }
        }

        /// <summary>
        /// Возращает и задает цвет.
        /// </summary>
        public string Colour { get; set; }

        /// <summary>
        /// Возвращает количество прямоугольников.
        /// </summary>
        /// <returns></returns>
        public static int AllRectanglesCount()
        {
            return _allRectangelsCount;
        }

        /// <summary>
        /// Возвращает ID.
        /// </summary>
        public int ID { get=> _id; }

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

            _centerX = rand.Next(50, 150);
            _centerY = rand.Next(50, 150);
            Center = new Point2D(_centerY,_centerX);

            _allRectangelsCount++;
            _id = _allRectangelsCount;
        }
    }
}
