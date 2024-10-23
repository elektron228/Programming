using ObjectOrientedPractics.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о накопительной скидке.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<int>
    {
        private int _points = 0;

        /// <summary>
        /// Возвращает количество накопленных баллов.
        /// </summary>
        public int Points 
        {
            get { return _points; }
            private set 
            { 
                if(value >= 0)
                {
                    _points = value;

                }
            } 
        }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                if (_points % 100 >= 11 && _points % 100 <= 14)
                {
                    return $"Накопительная - {_points} баллов";
                }

                int lastDigit = _points % 10;

                if (lastDigit == 1 && _points % 100 != 11)
                {
                    return $"Накопительная - {_points} балл";
                }
                else if (lastDigit >= 2 && lastDigit <= 4 && _points % 100 != 12 && _points % 100 != 13 && _points % 100 != 14)
                {
                    return $"Накопительная - {_points} балла";
                }
                else
                {
                    return $"Накопительная - {_points} баллов";
                }
            }
        }

        /// <summary>
        /// Возвращает размер доступной скидки.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Calculate(List<Item> items)
        {
            double sum = 0;
            foreach( var item in items)
            {
                sum += item.Cost;
            }

            double discount = (sum / 100) * 30;

            if (discount > _points)
            {
                return _points;
            }
            else
            {
                return discount;
            }
        }

        /// <summary>
        /// Применяет скидку к товарам. Списывает баллы.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Apply(List<Item> items)
        {
            double sum = 0;
            foreach (var item in items)
            {
                sum += item.Cost;
            }

            double discount = (sum / 100) * 30;

            if (discount > _points)
            {   
                discount = _points;
                _points = 0;
                return discount;
            }
            else
            {
                _points  -= Convert.ToInt32(discount);
                return discount;
            }

        }

        /// <summary>
        /// Начисляет баллы после покупки.
        /// </summary>
        /// <param name="items"></param>
        public void Update(List<Item> items)
        {
            double sum = 0;
            foreach (var item in items)
            {
                sum += item.Cost;
            }

            _points += Convert.ToInt32(sum / 10);
        }

        /// <summary>
        /// Сравнивает процент скидки.
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public int CompareTo(int points)
        {
            if (_points < points)
            {
                return -1;
            }
            if (_points > points)
            {
                return 1;
            }
            return 0;
        }
    }
}
