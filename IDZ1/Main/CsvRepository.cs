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

            if (!File.Exists(filePath)) return result;

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length < 2) return result;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length < 3) continue;

                Chef c = new Chef();
                c.Id = int.Parse(parts[0].Trim());
                c.FullName = parts[1].Trim();
                c.Specialty = parts[2].Trim();
                result.Add(c);
            }
            return result;
        }

        public List<Category> GetCategories()
        {
            List<Category> result = new List<Category>();
            string filePath = Path.Combine(_basePath, "categories.csv");

            if (!File.Exists(filePath)) return result;

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length < 2) return result;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length < 3) continue;

                Category c = new Category();
                c.Id = int.Parse(parts[0].Trim());
                c.Name = parts[1].Trim();
                c.Type = parts[2].Trim();
                result.Add(c);
            }
            return result;
        }

        public List<Dish> GetDishes()
        {
            List<Dish> result = new List<Dish>();
            string filePath = Path.Combine(_basePath, "dishes.csv");

            if (!File.Exists(filePath)) return result;

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length < 2) return result;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length < 6) continue;

                Dish d = new Dish();
                d.Id = int.Parse(parts[0].Trim());
                d.Name = parts[1].Trim();
                d.Chefid = int.Parse(parts[2].Trim());
                d.Categoryid = int.Parse(parts[3].Trim());
                d.Price = decimal.Parse(parts[4].Trim());
                d.Weight = int.Parse(parts[5].Trim());
                result.Add(d);
            }
            return result;
        }
    }
}