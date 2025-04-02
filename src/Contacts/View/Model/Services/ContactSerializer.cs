using Newtonsoft.Json;
using System.IO;
using NLog;
using System.Collections.ObjectModel;

namespace View.Model.Services
{
    /// <summary>
    /// Предоставляет методы для сериализации и десиреализации объектов класса<see cref="Contact"/>.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Объект, выполняющий логирование.
        /// </summary>
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Директория для сохранения данных.
        /// </summary>
        private readonly string _directoryPath = Path.Combine(Environment.
            GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");

        /// <summary>
        /// Путь к файлу с сохранёнными данными.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ContactSerializer"/>.
        /// </summary>
        public ContactSerializer()
        {
            try
            {
                _filePath = Path.Combine(_directoryPath, "contacts.json");
                if (!Directory.Exists(_directoryPath))
                {
                    Directory.CreateDirectory(_directoryPath);
                    _logger.Info($"Создана директория для сохранения контактов: {_directoryPath}");
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка при создании директории: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Выполняет сохранение объектов класса <see cref="Contact"/> в файл, используя 
        /// механизм сериализации.
        /// </summary>
        /// <param name="contacts">Список контактов для сохранения.</param>
        public void SaveContacts(ObservableCollection<Contact> contacts)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(contacts);
                File.WriteAllText(_filePath, jsonString);
                _logger.Info($"Контакты успешно сохранены в файл: {_filePath}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка при сохранении контактов в файл: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Выполняет загрузку объектов класса <see cref="Contact"/> из файла, используя 
        /// механизм десериализации.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<Contact> LoadContacts()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string json = File.ReadAllText(_filePath); 
                    ObservableCollection<Contact> contacts = 
                        JsonConvert.DeserializeObject<ObservableCollection<Contact>>(json); 
                    return contacts ?? new ObservableCollection<Contact>(); 
                }
                else
                {
                    _logger.Warn($"Файл контактов не найден: {_filePath}. " +
                        $"Возвращена пустая коллекция.");
                    return new ObservableCollection<Contact>();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Ошибка при загрузке контактов из файла: {ex.Message}" +
                        $"Возвращена пустая коллекция.");
                return new ObservableCollection<Contact>();
            }

        }
    }
}
