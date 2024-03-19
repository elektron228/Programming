using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    static class RectangleFactory
    {
        static Random random = new Random();
        static Colour colour;
        static string _rectColour;

        /// <summary>
        /// Создает экземпляр прмоугольника со случайными значениями.
        /// </summary>
        /// <returns></returns>
        public static Rectangle Randomize()
        {
            //Получаем случайные значения длины и ширины.
            int recLength = random.Next(20, 100);
            int recWide = random.Next(20, 100);

            //Присваиваем случайное значение цвета из перечисления Colour.
            int randomIndex = MainForm.ChooseRandomEnumIndex(colour);
            colour = (Colour)randomIndex;
            _rectColour = colour.ToString();

            Rectangle rect = new Rectangle(recWide, recLength, _rectColour);
            return rect;
        }

        /// <summary>
        /// Создает панельку, которая соответствует параметрам переданного прямоугольника.
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static Panel PanelFactory(Rectangle rect)
        {
            Panel newPanel = new Panel();
            newPanel.Size = new Size(rect.Wide, rect.Length);
            newPanel.Location = new Point(rect.Center.X, rect.Center.Y);
            newPanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            return newPanel;
        }
    }
}
