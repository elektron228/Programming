using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о покупателе.
    /// </summary>
    internal class Customer
    {
        private static int _id = 0;
        private string _fullName;
        private string _adress;

        /// <summary>
        /// Возвращает ID покупателя.
        /// </summary>
        public int CustomerID
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// Возвращает и задаёт имя покупателя. Должно быть до 200 символов.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (value.Length < 200)
                {
                    _fullName = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя. Должно быть до 500 символов.
        /// </summary>
        public string Adress
        {
            get { return _adress; }
            set
            {
                if (value.Length < 500)
                {
                    _adress = value;
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Имя покупателя. Должно быть до 200 символов.</param>
        /// <param name="adress">Адрес покупателя. Дожно быть до 500 символов.</param>
        public Customer(string fullName, string adress)
        {
            _id++;
            _fullName = fullName;
            _adress = adress;

        }
    }
}
