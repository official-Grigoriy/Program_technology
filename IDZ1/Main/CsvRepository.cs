using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class CsvRepository
    {
        private string _basePath;

        public CsvRepository(string basePath)
        {
            _basePath = basePath;
        }


        public List<Chef> GetChefs()
        {
            List<Chef> result = new List<Chef>();
            string filePath = Path.Combine(_basePath, "chefs.csv");

            if (!File.Exists(filePath))
                return result;

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length < 2)
                return result;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length < 3)
                    continue;

                Chef chef = new Chef();
                chef.Id = int.Parse(parts[0].Trim());
                chef.FullName = parts[1].Trim();
                chef.Specialty = parts[2].Trim();
                result.Add(chef);
            }

            return result;
        }


        public List<Category> GetCategories()
        {
            List<Category> result = new List<Category>();
            string filePath = Path.Combine(_basePath, "categories.csv");

            if (!File.Exists(filePath))
                return result;

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length < 2)
                return result;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length < 3)
                    continue;

                Category category = new Category();
                category.Id = int.Parse(parts[0].Trim());
                category.Name = parts[1].Trim();
                category.Type = parts[2].Trim();
                result.Add(category);
            }

            return result;
        }


        public List<Dish> GetDishes()
        {
            List<Dish> result = new List<Dish>();
            string filePath = Path.Combine(_basePath, "dishes.csv");

            if (!File.Exists(filePath))
                return result;

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length < 2)
                return result;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length < 6)
                    continue;

                Dish dish = new Dish();
                dish.Id = int.Parse(parts[0].Trim());
                dish.Name = parts[1].Trim();
                dish.Chefid = int.Parse(parts[2].Trim());
                dish.Categoryid = int.Parse(parts[3].Trim());
                dish.Price = decimal.Parse(parts[4].Trim());
                dish.Weight = int.Parse(parts[5].Trim());
                result.Add(dish);
            }
            return result;
        }
    }
}
