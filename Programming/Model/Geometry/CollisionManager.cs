using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Класс, проверяющий пересечения.
    /// </summary>
    public static class CollisionManager
    {
        /*
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
            Double wideSumm = ((rectangle1.Wide/2) + (rectangle2.Wide/2));
            Double lengthSum = ((rectangle1.Length/2) + (rectangle2.Length/2));

            //Проверка на пересечение.
            if (differenceX < wideSumm && differenceY < lengthSum)
            {
                result = true;
            }
            return result;
        }*/

        /// <summary>
        /// Проверяет, пересекаются ли прямоугольники.
        /// </summary>
        /// <param name="rectangle1"></param>
        /// <param name="rectangle2"></param>
        /// <returns></returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            int xMax1 = rectangle1.Center.X + rectangle1.Wide;
            int yMax1 = rectangle1.Center.Y + rectangle1.Length;
            int xMax2 = rectangle2.Center.X + rectangle2.Wide;
            int yMax2 = rectangle2.Center.Y + rectangle2.Length;

            if (rectangle1.Center.X >= xMax2 || rectangle2.Center.X >= xMax1)
            {
                return false;
            }

            if (rectangle1.Center.Y >= yMax2 || rectangle2.Center.Y >= yMax1)
            {
                return false;
            }

            return true;
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
