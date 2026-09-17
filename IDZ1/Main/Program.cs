namespace Main
{
    internal class Program
    {
        private static List<Chef> chefs;
        private static List<Category> categories;
        private static List<Dish> dishes;
        static void Main()
        {
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
                    LoadFromInMemory();
                    break;
                case 2:
                    CsvRepository();
                    break;
                default:
                    Console.WriteLine("неверный выбор");

            }
        }
        private static void LoadFromInMemory()
        {
            InMemoryRepository repo = new InMemoryRepository();

            chefs = repo.GetChefs();
            categories = repo.GetCategories();
            dishes = repo.GetDishes();
        }
        private static void LoadFromCsv(string path)
        {
            CsvRepository repo = new CsvRepository(path);

            chefs = repo.GetChefs();
            categories = repo.GetCategories();
            dishes = repo.GetDishes();
        }
    }
}
