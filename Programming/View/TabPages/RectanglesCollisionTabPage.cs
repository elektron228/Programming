using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.TabPages
{
    public partial class RectanglesCollisionTabPage : UserControl
    {
        public RectanglesCollisionTabPage()
        {
            InitializeComponent();
        }

        private void RectanglesCollisionTabPage_Load(object sender, EventArgs e)
        {
            FillRectangleArray(_rectangles,5);
        }

        //MainForm MainForm = new MainForm();

        //ClassesTabPage ClassesTabPage = new ClassesTabPage();

        private Rectangle _selectedRectangle;
        private List<Rectangle> _rectangles = new List<Rectangle>(0);

        //Объявляем список панелей.
        private List<Panel> _rectanglePanels = new List<Panel>(0);

        //Список для хранения информации о пересечении прямоугольников.
        List<bool> RectangleCollisions = new List<bool>();

        /// <summary>
        /// Очищает все текстбоксы связанные с прямоугольниками.
        /// </summary>
        public void ClearRectangleInfo()
        {
            RectanglesHeigthTextBox.Text = "";
            RectanglesWidthTextBox.Text = "";
            RectanglesXTextBox.Text = "";
            RectanglesYTextBox.Text = "";
            RectanglesIDTextBox.Text = "";
            //ClassesTabPage.ClearRectangleInfo();
        }

        /// <summary>
        /// Заполняем листбокс с прямоугольниками.
        /// </summary>
        /// <param name="rectangles"></param>
        public void FillRectListBoxs(List<Rectangle> rectangles)
        {
            RectanglesCollisionListBox.Items.Clear();
            string rectangle;
            for (int i = 0; i < rectangles.Count; i++)
            {
                rectangle = $"{rectangles[i].ID}. (X = {rectangles[i].Center.X}; Y = {rectangles[i].Center.Y}; W = {rectangles[i].Wide}; H = {rectangles[i].Length})";
                RectanglesCollisionListBox.Items.Add(rectangle);
            }
            ClearRectangleInfo();
            FindCollisions();
            //ClassesTabPage.FillRectListBox(rectangles);
        }

        /// <summary>
        /// Заполняет список прямоугольников значениями.
        /// </summary>
        /// <param name="rectangles"></param>
        public void FillRectangleArray(List<Rectangle> rectangles, int rectCount)
        {
            for (int i = 0; i < rectCount; i++)
            {
                //Создает прямоугольник.
                Rectangle rect = RectangleFactory.Randomize();
                rectangles.Add(rect);

                //Создает панель.
                Panel newPanel = RectangleFactory.PanelFactory(rect);
                _rectanglePanels.Add(newPanel);
                RectanglesPanel.Controls.Add(newPanel);
                RectangleCollisions.Add(false);
            }
            FillRectListBoxs(rectangles);
        }

        /// <summary>
        /// Анимируем кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRectPictBox_MouseMove(object sender, MouseEventArgs e)
        {
            AddRectPictBox.Size = new Size(42, 42);
            AddRectPictBox.Location = new Point(7, 200);
        }

        /// <summary>
        /// Анимируем кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRectPictBox_MouseLeave(object sender, EventArgs e)
        {
            AddRectPictBox.Size = new Size(40, 40);
            AddRectPictBox.Location = new Point(8, 201);
        }

        /// <summary>
        /// Анимируем кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelRectPictBox_MouseMove(object sender, MouseEventArgs e)
        {
            DelRectPictBox.Size = new Size(42, 42);
            DelRectPictBox.Location = new Point(53, 200);
        }

        /// <summary>
        /// Анимируем кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelRectPictBox_MouseLeave(object sender, EventArgs e)
        {
            DelRectPictBox.Size = new Size(40, 40);
            DelRectPictBox.Location = new Point(54, 201);
        }

        /// <summary>
        /// Удаляет выбранный прямоугольник из списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelRectPictBox_Click(object sender, EventArgs e)
        {
            try
            {
                _rectangles.Remove(_selectedRectangle);

                int selectedIndex = RectanglesCollisionListBox.SelectedIndex;
                _rectanglePanels.RemoveAt(selectedIndex);
                RectanglesPanel.Controls.RemoveAt(selectedIndex);

                FillRectListBoxs(_rectangles);
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// Добавляет прямоугольник в список.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRectPictBox_Click(object sender, EventArgs e)
        {
            FillRectangleArray(_rectangles, 1);
        }

        /// <summary>
        /// Меняет значения текстбоксов в зависимости от выбранного прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesCollisionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedRectIndex = RectanglesCollisionListBox.SelectedIndex;
                _selectedRectangle = _rectangles[selectedRectIndex];
                RectanglesHeigthTextBox.Text = _selectedRectangle.Length.ToString();
                RectanglesWidthTextBox.Text = _selectedRectangle.Wide.ToString();
                RectanglesXTextBox.Text = _selectedRectangle.Center.X.ToString();
                RectanglesYTextBox.Text = _selectedRectangle.Center.Y.ToString();
                RectanglesIDTextBox.Text = _selectedRectangle.ID.ToString();
            }
            catch (ArgumentOutOfRangeException) { }

        }

        /// <summary>
        /// Проверяем введенное в <see cref="RectanglesXTextBox"/> значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesXTextBox.Text != "")
            {
                //Получаем текст из строки.
                string currentText = RectanglesXTextBox.Text;
                try
                {
                    //Получаем индекс выбранного элемента.
                    int selectedIndex = RectanglesCollisionListBox.SelectedIndex;
                    //Пробуем парсить.
                    int x = int.Parse(currentText);
                    Validator.AssertValueInRange(x, 3, RectanglesPanel.Size.Width - 105);
                    RectanglesXTextBox.BackColor = Color.White;
                    //Меняем поля прямоугольника.
                    _selectedRectangle.Center = new Point2D(x, _selectedRectangle.Center.Y);
                    RectanglesCollisionListBox.Items[selectedIndex] = $"{_selectedRectangle.ID}. (X = {_selectedRectangle.Center.X}; Y = {_selectedRectangle.Center.Y}; W = {_selectedRectangle.Wide}; H = {_selectedRectangle.Length})";
                    //Меняем соотвествующую панельку.
                    _rectanglePanels[selectedIndex].Location = new Point(_selectedRectangle.Center.X, _selectedRectangle.Center.Y);
                    FindCollisions();
                }
                catch (Exception ex)
                {
                    RectanglesXTextBox.BackColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Проверяем введенное в <see cref="RectanglesYTextBox"/> значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesYTextBox.Text != "")
            {
                //Получаем индекс выбранного элемента.
                int selectedIndex = RectanglesCollisionListBox.SelectedIndex;
                //Получаем текст из строки.
                string currentText = RectanglesYTextBox.Text;
                try
                {
                    //Пробуем парсить.
                    int y = int.Parse(currentText);
                    Validator.AssertValueInRange(y, 3, RectanglesPanel.Size.Height - 105);
                    RectanglesYTextBox.BackColor = Color.White;
                    //Меняем поля прямоугольника.
                    _selectedRectangle.Center = new Point2D(_selectedRectangle.Center.X, y);
                    RectanglesCollisionListBox.Items[selectedIndex] = $"{_selectedRectangle.ID}. (X = {_selectedRectangle.Center.X}; Y = {_selectedRectangle.Center.Y}; W = {_selectedRectangle.Wide}; H = {_selectedRectangle.Length})";
                    //Меняем соотвествующую панельку.
                    _rectanglePanels[selectedIndex].Location = new Point(_selectedRectangle.Center.X, _selectedRectangle.Center.Y);
                    FindCollisions();
                }
                catch (Exception ex)
                {
                    RectanglesYTextBox.BackColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Проверяем введенное в <see cref="RectanglesWidthTextBox"/> значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {

            if (RectanglesWidthTextBox.Text != "")
            {
                //Получаем индекс выбранного элемента.
                int selectedIndex = RectanglesCollisionListBox.SelectedIndex;
                //Получаем текст из строки.
                string currentText = RectanglesWidthTextBox.Text;
                try
                {
                    //Пробуем парсить.
                    int width = int.Parse(currentText);
                    //Проверяем, находится ли введенное число в заданном диапазоне.
                    RectanglesWidthTextBox.BackColor = Color.White;
                    //Меняем поля прямоугольника.
                    _selectedRectangle.Wide = width;
                    RectanglesCollisionListBox.Items[selectedIndex] = $"{_selectedRectangle.ID}. (X = {_selectedRectangle.Center.X}; Y = {_selectedRectangle.Center.Y}; W = {_selectedRectangle.Wide}; H = {_selectedRectangle.Length})";
                    //Меняем соотвествующую панельку.
                    _rectanglePanels[selectedIndex].Size = new Size(_selectedRectangle.Wide, _selectedRectangle.Length);
                    FindCollisions();
                }
                catch (Exception ex)
                {
                    RectanglesWidthTextBox.BackColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Проверяем введенное в <see cref="RectanglesHeigthTextBox"/> значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesHeigthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesHeigthTextBox.Text != "")
            {
                //Получаем индекс выбранного элемента.
                int selectedIndex = RectanglesCollisionListBox.SelectedIndex;
                //Получаем текст из строки.
                string currentText = RectanglesHeigthTextBox.Text;
                try
                {
                    //Пробуем парсить.
                    int heigth = int.Parse(currentText);
                    //Проверяем, находится ли введенное число в заданном диапазоне.
                    RectanglesHeigthTextBox.BackColor = Color.White;
                    //Меняем поля прямоугольника.
                    _selectedRectangle.Length = heigth;
                    RectanglesCollisionListBox.Items[selectedIndex] = $"{_selectedRectangle.ID}. (X = {_selectedRectangle.Center.X}; Y = {_selectedRectangle.Center.Y}; W = {_selectedRectangle.Wide}; H = {_selectedRectangle.Length})";
                    //Меняем соотвествующую панельку.
                    _rectanglePanels[selectedIndex].Size = new Size(_selectedRectangle.Wide, _selectedRectangle.Length);
                    FindCollisions();
                }
                catch (Exception ex)
                {
                    RectanglesHeigthTextBox.BackColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Проверяет, пересекаются ли прямоугольники.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    bool isCollision = CollisionManager.IsCollision(_rectangles[i], _rectangles[j]);
                    if (isCollision && (i != j))
                    {
                        RectangleCollisions[i] = true;
                        break;
                    }
                    RectangleCollisions[i] = false;
                }
                //Если пересекаются то перекрашиваем.
                if (RectangleCollisions[i] && _rectanglePanels[i].BackColor == Color.FromArgb(127, 127, 255, 127))
                {
                    _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                }
                if (!RectangleCollisions[i] && _rectanglePanels[i].BackColor == Color.FromArgb(127, 255, 127, 127))
                {
                    _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
                }
            }

        }

    }
}
