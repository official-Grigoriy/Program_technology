namespace Main
{
    internal class Program
    {
        private static List<Chef> chefs;
        private static List<Category> categories;
        private static List<Dish> dishes;
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Выберите источник данных:");
            Console.WriteLine("1. InMemory Repository");
            Console.WriteLine("2. CSV Repository");
            Console.Write("Введите номер (1 или 2): ");

            string input = Console.ReadLine();
            int choice;

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("неверный ввод");
                return;
            }
            switch (choice)
            {
                case 1:
                    LoadFromInMemoryRepository();
                    break;
                case 2:
                    LoadFromCsvRepository("E:\\Code_Projects\\C#\\IDZ1\\Main\\data");
                    break;
                default:
                    Console.WriteLine("неверный выбор");
                    return;
            }
            RunProgram();
        }
        private static void LoadFromInMemoryRepository()
        {
            InMemoryRepository repo = new InMemoryRepository();

            chefs = repo.GetChefs();
            categories = repo.GetCategories();
            dishes = repo.GetDishes();
        }
        private static void LoadFromCsvRepository(string path)
        {
            CsvRepository repo = new CsvRepository(path);

            chefs = repo.GetChefs();
            categories = repo.GetCategories();
            dishes = repo.GetDishes();
        }
        private static void RunProgram()
        {
            // 1. FindChef
            Console.WriteLine("1.FindChef(\"Каре ягненка\")");
            Chef chef = FindChefByDishName("Каре ягненка");
            Console.WriteLine(chef != null ? chef.GetInfo() : "null");

            // 2. FindCategory
            Console.WriteLine("\n2. FindCategory(\"Борщ\"):");
            Category category = FindCategoryByDishName("Борщ");
            Console.WriteLine(category != null ? category.Info : "null");

            // 3. GetTotalWeight
            Console.WriteLine("\n3. GetTotalWeight:");
            Console.WriteLine($"{GetTotalWeight()} г");

            // 4. GetDishesByChefSortedByPrice
            Console.WriteLine("\n4. GetDishesByChefSortedByPrice(\"Adolf\"):");
            List<Dish> sortedDishes = GetDishesByChefSortedByPrice("Adolf");
            if (sortedDishes.Count > 0)
            {
                string result = "";
                for (int i = 0; i < sortedDishes.Count; i++)
                {
                    if (i > 0) result += ", ";
                    result += $"{sortedDishes[i].Name} ({sortedDishes[i].Price})";
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Не найдено");
            }

            // 5. PrintAllDishes
            Console.WriteLine("\n5. PrintAllDishes:");
            PrintAllDishes();
        }

        private static Chef FindChefByDishName(string dishName)
        {
            Dish targetDish = null;
            for (int i = 0; i < dishes.Count; i++)
            {
                if (dishes[i].Name == dishName)
                {
                    targetDish = dishes[i];
                    break;
                }
            }

            if (targetDish == null) return null;

            for (int i = 0; i < chefs.Count; i++)
            {
                if (chefs[i].Id == targetDish.Chefid)
                {
                    return chefs[i];
                }
            }

            return null;
        }

        private static Category FindCategoryByDishName(string dishName)
        {
            Dish targetDish = null;
            for (int i = 0; i < dishes.Count; i++)
            {
                if (dishes[i].Name == dishName)
                {
                    targetDish = dishes[i];
                    break;
                }
            }

            if (targetDish == null) return null;

            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].Id == targetDish.Categoryid)
                {
                    return categories[i];
                }
            }

            return null;
        }

        private static int GetTotalWeight()
        {
            int total = 0;
            for (int i = 0; i < dishes.Count; i++)
            {
                total += dishes[i].Weight;
            }
            return total;
        }

        private static List<Dish> GetDishesByChefSortedByPrice(string chefName)
        {
            Chef targetChef = null;
            for (int i = 0; i < chefs.Count; i++)
            {
                if (chefs[i].FullName == chefName)
                {
                    targetChef = chefs[i];
                    break;
                }
            }

            if (targetChef == null) return new List<Dish>();

            List<Dish> chefDishes = new List<Dish>();
            for (int i = 0; i < dishes.Count; i++)
            {
                if (dishes[i].Chefid == targetChef.Id)
                {
                    chefDishes.Add(dishes[i]);
                }
            }

            // Bubble sort by price
            for (int i = 0; i < chefDishes.Count - 1; i++)
            {
                for (int j = 0; j < chefDishes.Count - 1 - i; j++)
                {
                    if (chefDishes[j].Price > chefDishes[j + 1].Price)
                    {
                        Dish temp = chefDishes[j];
                        chefDishes[j] = chefDishes[j + 1];
                        chefDishes[j + 1] = temp;
                    }
                }
            }

            return chefDishes;
        }

        private static void PrintAllDishes()
        {
            for (int i = 0; i < dishes.Count; i++)
            {
                Dish dish = dishes[i];

                string chefName = "—";
                for (int j = 0; j < chefs.Count; j++)
                {
                    if (chefs[j].Id == dish.Chefid)
                    {
                        chefName = chefs[j].FullName;
                        break;
                    }
                }

                string categoryName = "—";
                for (int j = 0; j < categories.Count; j++)
                {
                    if (categories[j].Id == dish.Categoryid)
                    {
                        categoryName = categories[j].Name;
                        break;
                    }
                }

                Console.WriteLine($"\"{dish.GetInfo()}\" — повар {chefName}, категория \"{categoryName}\"");
            }
        }
    }
}

