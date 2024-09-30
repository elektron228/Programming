using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит информацию о заказе.
    /// </summary>
    public class Order
    {
        private static int _idCounter;
        private int _id;
        private float _totalPrice;
        private Address _deliveryAddress;
        private DateTime _creationDate;
        private List<Item> _items;

        /// <summary>
        /// Возвращает ID заказа.
        /// </summary>
        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// Возвращает общую стоимость корзины.
        /// </summary>
        public float TotalPrice
        {
            get
            {
                _totalPrice = 0;
                foreach (var item in _items)
                {
                    _totalPrice += item.Cost;
                }
                return _totalPrice;
            }
        }

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; } }

        /// <summary>
        /// Возвращает и задаёт адрес доставки.
        /// </summary>
        public Address CustomerAddress { get { return _deliveryAddress; }set { _deliveryAddress = value; } }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime CreationDate
        {
            get { return _creationDate; }
            private set { _creationDate = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="deliveryAddress"></param>
        public Order(List<Item> items, Address deliveryAddress)
        {
            _idCounter++;
            _id = _idCounter;
            Items = items;
            CustomerAddress = deliveryAddress;
            CreationDate = DateTime.Now;
        }
    }
}
