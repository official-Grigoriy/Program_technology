using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    /// <summary>
    /// id, название блюда, id шефа, id категории, цена, вес
    /// </summary>
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Chefid { get; set; }
        public int Categoryid { get; set; }
        public decimal Price { get; set; }
        public int Weight { get; set; }

        /// <summary>
        /// конструктор блюд по умолчанию
        /// </summary>
        public Dish() { }

        /// <summary>
        /// блюда с проверкой правил
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="chefid"></param>
        /// <param name="categoryid"></param>
        /// <param name="price"></param>
        /// <param name="weight"></param>
        /// <exception cref="ArgumentException"></exception>
        public Dish(int id, string name, int chefid, int categoryid, decimal price, int weight)
        {
            if (id <= 0) throw new ArgumentException("Id блюда должен быть больше 0.", nameof(id));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Название блюда не может быть пустым.", nameof(name));
            if (chefid <= 0) throw new ArgumentException("Chefid должен быть больше 0.", nameof(chefid));
            if (categoryid <= 0) throw new ArgumentException("Categoryid должен быть больше 0.", nameof(categoryid));
            if (price < 0) throw new ArgumentException("Цена не может быть отрицательной.", nameof(price));
            if (weight <= 0) throw new ArgumentException("Вес блюда должен быть строго больше 0.", nameof(weight)); // Правило из ТЗ

            Id = id;
            Name = name;
            Chefid = chefid;
            Categoryid = categoryid;
            Price = price;
            Weight = weight;
        }

        public decimal PricePerGramm => Price / Weight;
        public bool IsHeavy => Weight >= 500;
        public string GetInfo() => $"{Name} ({Price})руб., {Weight}гр.";
    }
}
