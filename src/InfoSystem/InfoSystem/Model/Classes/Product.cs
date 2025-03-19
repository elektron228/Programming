using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystem
{
    /// <summary>
    /// Хранит информацию о товаре.
    /// </summary>
    class Product
    {
        private string _name;
        private string _manufacturer;
        private Categories _category;
        private int _count;

        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает производителя.
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Возвращает и задает категорию.
        /// </summary>
        public Categories Category { get; set; }

        /// <summary>
        /// Возвращет и задает количество.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Product"/>.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="manufacturer"></param>
        /// <param name="category"></param>
        /// <param name="count"></param>
        public Product(string name, string manufacturer, Categories category,  int count)
        {
            Name = name;
            Manufacturer = manufacturer;
            Category = category;
            Count = count;
        }
    }
}
