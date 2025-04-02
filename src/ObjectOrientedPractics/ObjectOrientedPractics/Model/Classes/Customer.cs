using ObjectOrientedPractics.Model.Classes.Orders;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит информацию о покупателе.
    /// </summary>
    public class Customer
    {
        private int _id;
        private static int _idCounter = 0;
        private string _fullName;
        private Address _address = new Address();
        private Cart _cart;
        private List<Order> _orders = new List<Order>();
        private bool _isPriority = false;
        

        /// <summary>
        /// Возвращает ID покупателя.
        /// </summary>
        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// Возвращает и задаёт приоритет.
        /// </summary>
        public bool IsPriority { get { return _isPriority; } set { _isPriority = value; } }

        /// <summary>
        /// Возвращает и задаёт имя покупателя. Должно быть до 200 символов.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, FullName);
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя. Должно быть до 500 символов.
        /// </summary>
        public Address CustomerAddress
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт корзину покупателя.
        /// </summary>
        public Cart CustomerCart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        /// <summary>
        /// Возвращает и задаёт заказ.
        /// </summary>
        public List<Order> CustomerOrders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Возвращает и задаёт скидки.
        /// </summary>
        public List<IDiscount> Discounts { get; set; } = new List<IDiscount>();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Имя покупателя. Должно быть до 200 символов.</param>
        /// <param name="adress">Адрес покупателя. Дожно быть до 500 символов.</param>
        public Customer(string fullName)
        {
            _idCounter++;
            ID = _idCounter;
            FullName = fullName;
            CustomerCart = new Cart();
            PointsDiscount points = new PointsDiscount();
            Discounts.Add(points);
        }
    }
}
