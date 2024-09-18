using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Id товара.
        /// </summary>
        private int _id;
            
        /// <summary>
        /// Счётчик ID.
        /// </summary>
        private static int _idCounter = 0;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private float _cost;

        /// <summary>
        /// Возвращает Id товара.
        /// </summary>
        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// Возвращает и задаёт название товара. Должно быть до 200 символов.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, Name);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о товаре. Должно быть до 1000 символов.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, Info);
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара. Должно быть от 0 до 100 000.
        /// </summary>
        public float Cost
        {
            get { return _cost; }
            set
            {
                if (value >= 0 && value <= 100000)
                {
                    _cost = value;
                }
                else
                {
                    throw new ArgumentException("Стоимость товара должна быть от 0 до 100 000");
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляк класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара. Должно быть до 200 символов.</param>
        /// <param name="info">Информация о товаре. Должно быть до 1000 символов.</param>
        /// <param name="cost">Стоимость товара. Должна быть от 0 до 100 000.</param>
        public Item (string name, string info, float cost)
        {
            _idCounter++;
            ID = _idCounter;
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
