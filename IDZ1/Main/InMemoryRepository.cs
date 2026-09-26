using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    /// <summary>
    /// списки шефов, блюд, категорий
    /// </summary>
    public class InMemoryRepository
    {
        private List<Chef> _chefs;
        private List<Dish> _dishes;
        private List<Category> _categories;

        /// <summary>
        /// списки данных из памяти
        /// </summary>
        public InMemoryRepository()
        {
            _chefs = new List<Chef>
            {
                new Chef {Id = 1, FullName = "John", Specialty = "Повар" },
                new Chef {Id = 2, FullName = "Adolf", Specialty = "Шеф-повар" },
                new Chef {Id = 3, FullName = "Andrey", Specialty = "Кондитер" }
            };

            _categories = new List<Category>
            {
                new Category {Id = 1, Name = "Горячие блюда", Type = "Супы" },
                new Category {Id = 2, Name = "Горячие блюда", Type = "Мясо" },
                new Category {Id = 3, Name = "Горячие блюда", Type = "Лапша" },
                new Category {Id = 4, Name = "Напитки", Type = "алкогольные" },
                new Category {Id = 5, Name = "Напитки", Type = "безалкогольные" },
                new Category {Id = 6, Name = "Напитки", Type = "чаи" },
                new Category {Id = 7, Name = "Десерты", Type = "торты" },
                new Category {Id = 8, Name = "Десерты", Type = "мороженное" },
                new Category {Id = 9, Name = "Десерты", Type = "булки" }
            };

            _dishes = new List<Dish>
            {
                new Dish {Id = 1, Name = "Борщ", Chefid = 1,  Categoryid = 1, Price = 150, Weight = 300},
                new Dish {Id = 2, Name = "Каре ягненка", Chefid = 2,  Categoryid = 2, Price = 1500, Weight = 600},
                new Dish {Id = 3, Name = "Паста с грибами", Chefid = 2,  Categoryid = 3, Price = 500, Weight = 250},
                new Dish {Id = 4, Name = "Пиво", Chefid = 1,  Categoryid = 4, Price = 100, Weight = 500},
                new Dish {Id = 5, Name = "Сок", Chefid = 1,  Categoryid = 5, Price = 50, Weight = 400},
                new Dish {Id = 6, Name = "Черный чай", Chefid = 1,  Categoryid = 6, Price = 50, Weight = 500},
                new Dish {Id = 7, Name = "Графские развалины", Chefid = 1,  Categoryid = 7, Price = 2000, Weight = 700},
                new Dish {Id = 8, Name = "Пломбир", Chefid = 3,  Categoryid = 8, Price = 100, Weight = 300},
                new Dish {Id = 9, Name = "Синабон", Chefid = 1,  Categoryid = 9, Price = 5000, Weight = 400}
            };
        }
        public List<Chef> GetChefs() { return _chefs; }
        public List<Category> GetCategories() { return _categories; }
        public List<Dish> GetDishes() { return _dishes; }
    }   
}
