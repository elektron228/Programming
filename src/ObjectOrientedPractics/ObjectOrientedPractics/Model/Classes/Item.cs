using ObjectOrientedPractics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит информацию о товаре.
    /// </summary>
    public class Item : ICloneable,IEquatable<object>, IComparable<float>
    {
        
        private readonly int _id;
        private static int _idCounter = 0;
        private string _name;
        private string _info;
        private float _cost;

        public event EventHandler NameChanged;
        public event EventHandler CostChanged;
        public event EventHandler InfoChanged;

        /// <summary>
        /// Возвращает Id товара.
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задаёт название товара. Должно быть до 200 символов.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    ValueValidator.AssertStringOnLength(value, 200, Name);
                    _name = value;
                    OnNameChanged();
                }
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
                if (_info != value)
                {
                    ValueValidator.AssertStringOnLength(value, 1000, Info);
                    _info = value;
                    OnInfoChanged();
                }
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
                if( _cost != value)
                {
                    if (value >= 0 && value <= 100000)
                    {
                        _cost = value;
                        OnCostChanged();
                    }
                    else
                    {
                        throw new ArgumentException("Стоимость товара должна быть от 0 до 100 000");
                    }
                }
                
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию товара.
        /// </summary>
        public Category Category { get; set; } = new Category();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара. Должно быть до 200 символов.</param>
        /// <param name="info">Информация о товаре. Должно быть до 1000 символов.</param>
        /// <param name="cost">Стоимость товара. Должна быть от 0 до 100 000.</param>
        public Item (string name, string info, float cost)
        {
            _idCounter++;
            _id = _idCounter;
            Name = name;
            Info = info;
            Cost = cost;
            Category = Category.Food;
        }

        /// <summary>
        /// Создаёт копию товара.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Item(this.Name, this.Info, this.Cost) {Category = this.Category };
        }

        /// <summary>
        /// Сравнивает объекты адреса
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (other is Item)
            {
                return (Item)other == (Item)this;

            }
            return false;
        }

        /// <summary>
        /// Сравнивает процент скидки.
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public int CompareTo(float cost)
        {
            if (_cost < cost)
            {
                return -1;
            }
            if (_cost > cost)
            {
                return 1;
            }
            return 0;
        }

        private void OnNameChanged()
        {
            NameChanged?.Invoke(this, EventArgs.Empty);
            Debug.Write("\n NameChanged");
        }

        private void OnCostChanged()
        {
            CostChanged?.Invoke(this, EventArgs.Empty);
            Debug.Write("\n CostChanged");
        }

        private void OnInfoChanged()
        {
            InfoChanged?.Invoke(this, EventArgs.Empty);
            Debug.Write("\n InfoChanged");
        }
    }
}
