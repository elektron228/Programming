using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли прямоугольники.
        /// </summary>
        /// <param name="rectangle1"></param>
        /// <param name="rectangle2"></param>
        /// <returns></returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            bool result = false;

            //Расстояние между координатами.
            int differenceX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            int differenceY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            //Сумма значений.
            Double wideSumm = (rectangle1.Wide + rectangle2.Wide)/2;
            Double lengthSum = (rectangle1.Length + rectangle2.Length)/2;

            //Проверка на пересечение.
            if (differenceX < wideSumm && differenceY < lengthSum)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// проверяет, пересекаются ли кольца.
        /// </summary>
        /// <param name="ring1"></param>
        /// <param name="ring2"></param>
        /// <returns></returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            bool result = false;

            //Расстояние между координатами.
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);

            //Расстояние между центрами.
            Double distance = Math.Pow( ((dX * dX) + (dY * dY)), 0.5);

            //Проверка на пересечение.
            if (distance < (ring1.OuterRadius + ring2.OuterRadius))
            {
                result = true;
            }
            return result;
        }
    }
}
