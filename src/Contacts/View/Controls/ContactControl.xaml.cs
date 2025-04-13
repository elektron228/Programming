using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace View.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Запрещает ввод недопустимых символов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[\d\+\-\(\)]+$"))
            {
                e.Handled = true; 
            }
        }

        /// <summary>
        /// Запрещает вставку недопустимых символов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string pastedText = (string)e.DataObject.GetData(typeof(string));
                if (!Regex.IsMatch(pastedText, @"^[\d\+\-\(\)]+$")) 
                {
                    e.CancelCommand(); 
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}
