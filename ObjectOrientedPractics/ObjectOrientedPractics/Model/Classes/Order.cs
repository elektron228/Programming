using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
