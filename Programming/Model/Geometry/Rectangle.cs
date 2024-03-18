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
        private int _length;
        private int _wide;
        private string _colour;
        private int _centerX;
        private int _centerY;
        private int _id;
        private static int _allRectangelsCount = 0;
        Random rand = new Random();
        
        /// <summary>
        /// Возвращает центр прямоугольника.
        /// </summary>
        public Point2D Center {  get; set; }

        /// <summary>
        /// Возвращает и задает длину. Должно быть не меньше нуля.
        /// </summary>
        public int Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                Validator.AssertValueInRange(value, 1, 50);
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину. Должно быть не меньше нуля.
        /// </summary>
        public int Wide
        {
            get { return _wide; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                Validator.AssertValueInRange(value, 1, 50);
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
        public Rectangle(int wide, int length, string colour)
        {
            Length = length;
            Wide = wide; 
            Colour = colour;

            _centerX = rand.Next(50, 405);
            _centerY = rand.Next(50, 445);
            Center = new Point2D(_centerX,_centerY);

            _allRectangelsCount++;
            _id = _allRectangelsCount;
        }
    }
}
