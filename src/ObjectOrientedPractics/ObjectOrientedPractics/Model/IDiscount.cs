using ObjectOrientedPractics.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Содержит методы для взаимодействия со скидками.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращет информацию о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Расчитывает возможную скидку.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        double Calculate(List<Item> items);
        
        /// <summary>
        /// Применяет скидку.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет данные.
        /// </summary>
        /// <param name="items"></param>
        void Update(List<Item> items);
    }
}
