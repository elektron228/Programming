using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о рейсе.
    /// </summary>
    public class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTime;

        /// <summary>
        /// Возвращает и задает пункт вылета.
        /// </summary>
        public string DeparturePoint { get; set; } 

        /// <summary>
        /// Возвращает и задает пункт назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает время полета. Должно быть не меньше нуля.
        /// </summary>
        public int FlightTime
        {
            get { return _flightTime; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTime = value;
            }
        }    

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Место вылета.</param>
        /// <param name="destination">Место назначения.</param>
        /// <param name="flightTime">Время полета.</param>
        public Flight(string departurePoint,  string destination, int flightTime)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight() { }
    }
}
