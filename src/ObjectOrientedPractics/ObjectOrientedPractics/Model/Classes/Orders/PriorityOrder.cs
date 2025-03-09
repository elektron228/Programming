using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes.Orders
{
    public class PriorityOrder : Order
    {
        private DeliveryTime _deliveryTime;
        private DateTime _deliveryDate;

        /// <summary>
        /// Возвращает и задаёт время доставки.
        /// </summary>
        public DeliveryTime DesiredDeliveryTime
        {
            get { return _deliveryTime; }
            set { _deliveryTime = value; }
        }

        /// <summary>
        /// Возвращает и задаёт дату доставки.
        /// </summary>
        public DateTime DeliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="customerName">Имя покупателя.</param>
        /// <param name="totalPrice">Итоговая цена.</param>
        /// <param name="desiredDeliveryTime">Время доставки.</param>
        /// <param name="deliveryDate">Дата доставки.</param>
        public PriorityOrder(List<Item> items, Address deliveryAddress, string customerName, float totalPrice, int customerId, DeliveryTime desiredDeliveryTime, DateTime deliveryDate) : base(items, deliveryAddress, customerName, totalPrice, customerId)
        {
            DesiredDeliveryTime = desiredDeliveryTime;
            DeliveryDate = deliveryDate;
        }
    }
}
