using ObjectOrientedPractics.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Содержит методы для обработки данных.
    /// </summary>
    public class DataTools
    {
        /// <summary>
        /// Делегат для фильтрации.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public delegate bool FilterCriteria(Item item);

        /// <summary>
        /// Метод фильтрации.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public  List<Item> Filter(List<Item> items, FilterCriteria criteria)
        {
            List<Item> filteredItems = new List<Item>();
            foreach(var item in items)
            {
                if(criteria(item))
                {
                    filteredItems.Add(item);
                }
            }
            return filteredItems;
        }

        /// <summary>
        /// Критерий для фильтрации по стоимости
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public  bool FilterByPrice(Item item)
        {
            return item.Cost > 5000;
        }

        /// <summary>
        /// Критерий для фильтрации по категории.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public  bool FilterByCategory(Item item)
        {
            return item.Category == Category.Food; 
        }

        /// <summary>
        /// Делегат для сортировки
        /// </summary>
        /// <param name="Items"></param>
        /// <returns></returns>
        public delegate List<Item> SortCriteria(List<Item> Items);

        /// <summary>
        /// Метод сортировки
        /// </summary>
        /// <param name="Items"></param>
        /// <param name="criteria"></param>
        /// <returns></returns>
        public List<Item> Sort(List<Item> Items, SortCriteria criteria)
        {
            return criteria(Items);
        }

        /// <summary>
        /// Критерий сортировки по имени
        /// </summary>
        /// <param name="Items"></param>
        /// <returns></returns>
        public List<Item> SortByName(List<Item> Items)
        {
            List<Item> sortedItems = new List<Item>(Items);
            for (int i = 0; i < sortedItems.Count - 1; i++)
            {
                for (int j = i + 1; j < sortedItems.Count; j++)
                {
                    if (string.Compare(sortedItems[i].Name, sortedItems[j].Name) > 0)
                    {
                        // Меняем местами элементы
                        Item temp = sortedItems[i];
                        sortedItems[i] = sortedItems[j];
                        sortedItems[j] = temp;
                    }
                }
            }
            return sortedItems;
        }

        /// <summary>
        /// Критерий сортировки по возрастанию стоимости
        /// </summary>
        /// <param name="Items"></param>
        /// <returns></returns>
        public List<Item> SortByPriceAscending(List<Item> Items)
        {
            List<Item> sortedItems = new List<Item>(Items);
            for (int i = 0; i < sortedItems.Count - 1; i++)
            {
                for (int j = i + 1; j < sortedItems.Count; j++)
                {
                    if (sortedItems[i].Cost > sortedItems[j].Cost)
                    {
                        // Меняем местами элементы
                        Item temp = sortedItems[i];
                        sortedItems[i] = sortedItems[j];
                        sortedItems[j] = temp;
                    }
                }
            }
            return sortedItems;
        }

        /// <summary>
        /// Критерий сортировки по убыванию стоимости
        /// </summary>
        /// <param name="Items"></param>
        /// <returns></returns>
        public List<Item> SortByPriceDescending(List<Item> Items)
        {
            List<Item> sortedItems = new List<Item>(Items);
            for (int i = 0; i < sortedItems.Count - 1; i++)
            {
                for (int j = i + 1; j < sortedItems.Count; j++)
                {
                    if (sortedItems[i].Cost < sortedItems[j].Cost)
                    {
                        // Меняем местами элементы
                        Item temp = sortedItems[i];
                        sortedItems[i] = sortedItems[j];
                        sortedItems[j] = temp;
                    }
                }
            }
            return sortedItems;
        }
    }
}
