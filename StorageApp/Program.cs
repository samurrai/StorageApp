using StorageApp.Models;
using StorageApp.Services;

namespace StorageApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            StorageService storageService = new StorageService();
            storageService.AddPressed += storageService.WriteToXml;

            while (true)
            {
                System.Console.WriteLine("Введите название продукта");
                string nameOfProduct = System.Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nameOfProduct))
                {
                    nameOfProduct = "none";
                }
                System.Console.WriteLine("Введите цену продукта");
                int priceOfProduct = 0;
                if (int.TryParse(System.Console.ReadLine(), out int result) && result > 0)
                {
                    priceOfProduct = result;
                }
                Product product = new Product
                {
                    Name = nameOfProduct,
                    Cost = priceOfProduct
                };
                System.Console.WriteLine("Нажмите Enter для добавления продукта");
                System.Console.ReadLine();
                storageService.AddPressedEvent(product);
                System.Console.WriteLine("Хотите выйти?(yes - да)");
                var choice = System.Console.ReadLine();
                choice.ToLower();
                if (choice == "yes")
                {
                    break;
                }
            }
        }
    }
}
