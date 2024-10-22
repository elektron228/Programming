using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes.Orders
{
    /// <summary>
    /// Хранит информацию о заказе.
    /// </summary>
    public class Order
    {
        private static int _idCounter;
        private protected int _id;
        private protected double _amount;
        private protected string _customerFullName;
        private protected int _customerId;
        private protected Address _deliveryAddress;
        private protected DateTime _creationDate;
        private protected OrderStatus _status;
        private protected List<Item> _items = new List<Item>();

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
        public double Amount
        {
            get
            {
                _amount = 0;
                foreach (var item in _items)
                {
                    _amount += item.Cost;
                }
                return _amount;
            }
        }

        /// <summary>
        /// Возвращает размер применённой скидки.
        /// </summary>
        public float DiscounAmount 
        { 
            get; 
            private set; 
        }

        public double TotalPrice
        {
            get
            {
               double amount = Amount;
               return amount - DiscounAmount;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя покупателя, сделавшего заказ.
        /// </summary>
        public string CustomerFullName { get { return _customerFullName; } set { _customerFullName = value; } }

        /// <summary>
        /// Возвращает id покупателя.
        /// </summary>
        public int CustomerId { get { return _customerId; } private set { _customerId = value; } }

        /// <summary>
        /// Возвращает и задаёт статус товара.
        /// </summary>
        public OrderStatus Status { get { return _status; } set { _status = value; } }

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
        /// <param name="items">Список товаров.</param>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="customerName">Имя покупателя.</param>
        /// <param name="totalPrice">Размер скидки.</param>
        public Order(List<Item> items, Address deliveryAddress, string customerName, float totalPrice, int customerId)
        {
            _idCounter++;
            _id = _idCounter;
            foreach (Item item in items)
            {
                _items.Add(item);
            }
            CustomerAddress = deliveryAddress;
            CreationDate = DateTime.Now;
            Status = OrderStatus.New;
            CustomerFullName = customerName;
            CustomerId = customerId;
            DiscounAmount = totalPrice;
        }
    }
}
