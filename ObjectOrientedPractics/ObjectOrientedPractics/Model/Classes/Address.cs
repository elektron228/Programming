using ObjectOrientedPractics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    public class Address : ICloneable , IEquatable<object>
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        public event EventHandler AddressChanged;

        /// <summary>
        /// Возвращет и задаёт индекс. Целое шестизначное число.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                if (_index != value)
                {
                    if (value.ToString().Length != 6)
                    {
                        throw new ArgumentException("Индекс должен быть шестизначным числом.");
                    }
                    _index = value;
                    OnAddressChanged();
                }
                
            }
        }

        /// <summary>
        ///Возвращает и задаёт страну. Не более 50 символов. 
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    ValueValidator.AssertStringOnLength(value, 50, "Country");
                    _country = value;
                    OnAddressChanged();
                }
                
            }
        }

        /// <summary>
        /// Возвращает и задаёт город. Не более 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    ValueValidator.AssertStringOnLength(value, 50, "City");
                    _city = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт улицу. Не более 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                if (_street != value)
                {
                    ValueValidator.AssertStringOnLength(value, 100, "Street");
                    _street = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома. Не более 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                if (_building != value)
                {
                    ValueValidator.AssertStringOnLength(value, 10, "Building");
                    _building = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры. Не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                if (_apartment != value)
                {
                    ValueValidator.AssertStringOnLength(value, 10, "Apartment");
                    _apartment = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 111111;
            Country = "Example country";
            City = "Example City";
            Street = "Example Street";
            Building = "11";
            Apartment = "11";
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс, целое шестизначное число.</param>
        /// <param name="country">Страна/регион, строка, не более 50 символов.</param>
        /// <param name="city">Город (населенный пункт), строка, не более 50 символов.</param>
        /// <param name="street">Улица, строка, не более 100 символов.</param>
        /// <param name="building">Номер дома, строка, не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения, не более 10 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Копирует объект адреса.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment);
        }

        /// <summary>
        /// Сравнивает объекты адреса
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (other is Address)
            {
                return (Address)other == (Address)this;

            }
            return false;
        }

        private void OnAddressChanged()
        {
            AddressChanged?.Invoke(this, EventArgs.Empty);
            Debug.Write("\nAddressChenged");
        }
    }
}
