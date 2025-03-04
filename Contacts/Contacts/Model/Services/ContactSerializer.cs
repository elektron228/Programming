using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    class ContactSerializer
    {
        private string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts", "contacts.json");

        /// <summary>
        /// Возвращает и задаёт путь для сохранения данных.
        /// </summary>
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        /// <summary>
        /// Выполняет сохранение объектов класса <see cref="Contact"/> в файл, используя механизм сериализации.
        /// </summary>
        /// <param name="contacts"></param>
        public void SaveContact(List<Contact> contacts)
        {
            try
            {
                // Сериализуем объект Contact в JSON строку
                string jsonString = JsonConvert.SerializeObject(contacts);

                // Записываем JSON строку в файл
                File.WriteAllText(_filePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении контакта в файл: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Выполняет загрузку объектов класса <see cref="Contact"/> из файла, используя механизм десериализации.
        /// </summary>
        /// <param name="contacts"></param>
        public void LoadContacts(ref List<Contact> contacts)
        {
            try
            {
                // Проверяем, существует ли файл
                if (!File.Exists(_filePath))
                {
                    return;
                }

                // Читаем JSON строку из файла
                string jsonString = File.ReadAllText(_filePath);

                // Десериализуем JSON строку в объект Contact
                contacts = JsonConvert.DeserializeObject<List<Contact>>(jsonString);

                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке контакта из файла: {ex.Message}");
                return; 
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ContactSerializer"/>.
        /// </summary>
        public ContactSerializer()
        {
            // Проверяем, существует ли директория, и создаем ее, если нет.
            string directoryPath = Path.GetDirectoryName(_filePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
    }
}
