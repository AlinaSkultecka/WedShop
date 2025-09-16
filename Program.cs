using WedShop.ProductData;

namespace WedShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> inventory = new List<Product>()
            {
                new Book { Name = "The Great Gatsby", Brand = "Scribner", Price = 10.99, Author = "F. Scott Fitzgerald" },
                new Electronics { Name = "Smartphone", Brand = "TechBrand", Price = 699.99, WarrantyYears = 2 },
                new Clothing { Name = "T-Shirt", Brand = "FashionCo", Price = 19.99, Size = "M" }
            };

            bool running = true;
            while (running)
            {
                Console.WriteLine("=== Alina's workshop ===");
                Console.WriteLine("[1] Add a Product");
                Console.WriteLine("[2] List of the Products");
                Console.WriteLine("[3] Amount of Products");
                Console.WriteLine("[4] Total value of Products");
                Console.WriteLine("[5] Set Global Discount");
                Console.WriteLine("[0] Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You choose add a product");
                        AddProductMenu(inventory);
                        break;

                    case 2:
                        Console.WriteLine("You choose see list of the products");
                        ListProducts(inventory);
                        break;

                    case 3:
                        Console.WriteLine("You choose see amount of products");
                        Console.WriteLine(Product.TotalCount);
                        break;

                    case 4:
                        Console.WriteLine("You choose total value of products");
                        Console.WriteLine($" The total value of your products is {CalculateTotalValue(inventory)}");
                        break;

                    case 5:
                        Console.WriteLine("");
                        ChangeGlobalDiscount();
                        Console.WriteLine($" New global discount is {Product.GlobalDiscount * 100}%");
                        break;

                    case 0:
                        Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;


                }
            }
            static void AddProductMenu(List<Product> inventory)
            {
                Console.WriteLine("[1] Book");
                Console.WriteLine("[2] Electronics");
                Console.WriteLine("[3] Clothing");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Book b = new Book();
                        FillCommonFields(b);
                        Console.Write("Enter the author:");
                        b.Author = Console.ReadLine();
                        inventory.Add(b);
                        break;
                    case 2:
                        Electronics e = new Electronics();
                        FillCommonFields(e);
                        Console.Write("Enter warranty in years:");
                        e.WarrantyYears = int.Parse(Console.ReadLine());
                        inventory.Add(e);
                        break;
                    case 3:
                        Clothing c = new Clothing();
                        FillCommonFields(c);
                        Console.Write("Enter the size:");
                        c.Size = Console.ReadLine();
                        inventory.Add(c);
                        break;
                    default:

                        Console.WriteLine("Invalid choice, please try again.");
                        break;


                }

            }

            static void FillCommonFields(Product p)
            {
                Console.Write("Enter the name:");
                p.Name = Console.ReadLine();
                Console.Write("Enter the brand:");
                p.Brand = Console.ReadLine();
                Console.Write("Enter the price:");
                p.Price = double.Parse(Console.ReadLine());
            }

            static void ListProducts(List<Product> products)
            {
                foreach (Product p in products)
                {
                    Console.WriteLine(p.ProductDetails());
                }
            }

            static double CalculateTotalValue(List<Product> products)
            {
                double sum = 0;
                foreach (Product p in products)
                {
                    sum += p.Price;
                }
                return sum;
            }

            static void ChangeGlobalDiscount()
            {
                Console.Write("New discount in %: ");
                double percent = double.Parse(Console.ReadLine());
                Product.SetGlobalDiscountPercent(percent);
            }



        }
}
