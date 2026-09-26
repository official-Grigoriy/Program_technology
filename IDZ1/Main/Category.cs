using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    /// <summary>
    /// id, название категоии, тип
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// конструктор категорий по умолчанию
        /// </summary>
        public Category() { }

        /// <summary>
        /// уонструктор категорий с проверкой правил
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <exception cref="ArgumentException"></exception>
        public Category(int id, string name, string type)
        {
            if (id <= 0) throw new ArgumentException("Id категории должен быть больше 0.", nameof(id));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Название категории не может быть пустым.", nameof(name));
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentException("Тип категории не может быть пустым.", nameof(type));

            Id = id;
            Name = name;
            Type = type;
        }

        /// <summary>
        /// имя-фамилия
        /// </summary>
        public string Info => $"{Name} - {Type}";
    }
}