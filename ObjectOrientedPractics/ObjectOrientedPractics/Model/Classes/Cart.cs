using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит информацию о корзине товаров.
    /// </summary>
    public class Cart
    {
        private List<Item> _items;

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; } }

        /// <summary>
        /// Возвращает стоимость всех товаров в корзине.
        /// </summary>
        public float Amount
        {
            get
            {
                if (_items.Count == 0 || _items == null)
                {
                    return 0f;
                }
                else 
                {
                    float amount = 0f;
                    foreach (Item item in _items)
                    {
                        amount += item.Cost;
                    }
                    return amount;
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

    }
}
