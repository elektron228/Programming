using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о кольце.
    /// </summary>
    public class Ring
    {
        private Double _outerRadius;
        private Double _innerRadius;
        private Point2D _center;
        private Double _p = 3.14;
        private int _centerX;
        private int _centerY;
        Random rand = new Random();

        /// <summary>
        /// Возвращает и задает внешний радиус. Должно быть от 0 до 50.
        /// </summary>
        public Double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                Validator.AssertValueIsMore(value, _innerRadius);
                Validator.AssertValueInRange(value, 0, 50);
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус. Должно быть от 0 до 50.
        /// </summary>
        public Double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                Validator.AssertValueIsMore(_outerRadius, value);
                Validator.AssertValueInRange(value, 0, 50);
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает центр кольца. Типа <see cref="Point2D"/>
        /// </summary>
        public Point2D Center { get; private set;  }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public Double Area
        {
            get => (_p * (OuterRadius*OuterRadius)) - (_p * (InnerRadius * InnerRadius)); 
            private set { }
        }

        /// <summary>
        /// Создает объект класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус.</param>
        /// <param name="innerRadius">Внутренний радиус.</param>
        public Ring(Double outerRadius, Double innerRadius)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;

            _centerX = rand.Next(50, 150);
            _centerY = rand.Next(50, 150);
            Center = new Point2D(_centerY, _centerX);
        }
    }
}
