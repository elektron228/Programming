using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PercentDiscount : IDiscount
    {
        private int _percent = 1;
        private Category _category;
        private double _totalSum;

        /// <summary>
        /// Возвращает размер скидки в процентах.
        /// </summary>
        public int Percent
        {
            get { return _percent; }
            private set { _percent = value; }
        }

        /// <summary>
        /// Возвращает категорию скидки.
        /// </summary>
        public Category Category { get { return _category; } }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная '{_category}' - {_percent}%";
            }
        }

        /// <summary>
        /// Возвращает размер доступной скидки.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Calculate(List<Item> items)
        {
            int percent = _percent;
            double sum = 0;
            foreach (var item in items)
            {
                if (item.Category == _category)
                {
                    sum += item.Cost;
                }
            }
            double sum2 = sum;
            while((sum2 >= 1000) && (percent < 10))
            {
                sum -= 1000;
                percent++;
            }
            return (sum / 100) * percent;
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Apply(List<Item> items)
        {
            double sum = 0;
            foreach (var item in items)
            {
                if (item.Category == _category)
                {
                    sum += item.Cost;
                }
            }
            double sum2 = sum;
            while ((sum2 >= 1000) && (_percent < 10))
            {
                sum -= 1000;
                _percent++;
            }
            return (sum / 100) * _percent;

        }

        /// <summary>
        /// Обновляет итоговую сумму покупок.
        /// </summary>
        /// <param name="items"></param>
        public void Update(List<Item> items)
        {
            foreach (var item in items)
            {
                if (item.Category == _category)
                {
                    _totalSum += item.Cost;
                }
            }
        }

        public PercentDiscount(Category category)
        {
            _category = category;
        }
    }
}
