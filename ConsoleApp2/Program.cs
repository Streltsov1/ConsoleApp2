using ConsoleApp3;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 1;
            do
            {
                Console.WriteLine("\n\t\tMenu");
                Console.WriteLine("1 - Add data to table");
                Console.WriteLine("2 - Show data table");
                Console.WriteLine("3 - Show information about shop");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("Enter your option");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    AddDataMenu();
                }
                else if (menu == 2)
                {
                    ShowTableMenu();
                }
                else if (menu == 3)
                {
                    ShowInformationAboutShop();
                }
                else if (menu == 0)
                    break;
                else
                    continue;
            } while(menu != 0);
        }
        static void ShowTableMenu()
        {
            NewDbContext db = new();
            int show = 1;
            do
            {
                Console.WriteLine("\n\tShow data table");
                Console.WriteLine("1 - Category");
                Console.WriteLine("2 - City");
                Console.WriteLine("3 - Country");
                Console.WriteLine("4 - Position");
                Console.WriteLine("5 - Product");
                Console.WriteLine("6 - Shop");
                Console.WriteLine("7 - Worker");
                Console.WriteLine("0 - Back");
                Console.WriteLine("Enter your option");
                show = int.Parse(Console.ReadLine());
                if (show == 1)
                {
                    var category = db.Categories;
                    Console.WriteLine("categories:");
                    foreach (var i in category)
                    {
                        Console.WriteLine($"[{i.Id}] Name:{i.Name}");
                    }
                }
                else if (show == 2)
                {
                    var city = db.Cities;
                    Console.WriteLine("Cities:");
                    foreach (var i in city)
                    {
                        Console.WriteLine($"[{i.Id}] Name:{i.Name} Country:{i.CountryId}");
                    }
                }
                else if (show == 3)
                {
                    var country = db.Countries;
                    Console.WriteLine("Countries:");
                    foreach (var i in country)
                    {
                        Console.WriteLine($"[{i.Id}] Name:{i.Name}");
                    }
                }
                else if (show == 4)
                {
                    var position = db.Positions;
                    Console.WriteLine("Positions:");
                    foreach (var i in position)
                    {
                        Console.WriteLine($"[{i.Id}] Name:{i.Name}");
                    }
                }
                else if (show == 5)
                {
                    var product = db.Products;
                    Console.WriteLine("Products:");
                    foreach (var i in product)
                    {
                        Console.WriteLine($"[{i.Id}] Name:{i.Name} Price: {i.Price}$ Discount: {i.Discount}% Category:{i.CategoryId} Quantity:{i.Quantity} IsInStocks:{i.IsInStock}");
                    }
                }
                else if (show == 6)
                {
                    var shop = db.Shops;
                    Console.WriteLine("Shops:");
                    foreach (var i in shop)
                    {
                        Console.WriteLine($"[{i.Id}] Name:{i.Name} Address:{i.Address} City:{i.CityId} ParkingArea:{i.ParkingArea}");
                    }
                }
                else if (show == 7)
                {
                    var worker = db.Workers;
                    Console.WriteLine("Workers:");
                    foreach (var i in worker)
                    {
                        Console.WriteLine($"[{i.Id}] Name:{i.Name} Surname:{i.Surname} Salary:{i.Salary} Email:{i.Email} Phone:{i.PhoneNumber} Position:{i.PositionId} Shop:{i.ShopId}");
                    }
                }
                else if (show == 0)
                {
                    break;
                }
                else
                    continue;
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
            } while (show != 0);
        }
        static void ShowInformationAboutShop()
        {
            NewDbContext db = new();
            var shop = db.Shops.Include(x => x.City)
                               .Include(x => x.Workers)
                               .Include(x => x.Products);
            Console.WriteLine("Shops:");
            foreach (var i in shop)
            {
                Console.WriteLine($"[{i.Id}] Name:{i.Name} Address:{i.Address} City:{i.City.Name} ParkingArea:{i.ParkingArea}");
                Console.Write("Workers: ");
                for (int j = 0; j < i.Workers.ToList().Count; j++)
                {
                    Console.Write($"{i.Workers.ToList()[j].Name} {i.Workers.ToList()[j].Surname}, ");
                }
                Console.WriteLine();
                Console.Write("Products: ");
                for (int j = 0; j < i.Products.ToList().Count; j++)
                {
                    Console.Write($"{i.Products.ToList()[j].Name}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }
        static void AddDataMenu()
        {
            NewDbContext db = new();
            int menu = 1;
            string name;
            string surname;
            string email;
            string phoneNumber;
            decimal salary;
            float discount;
            decimal price;
            int quantity;
            bool isInStock;
            int categoryId;
            int countryId;
            int positionId;
            int shopId;
            string address;
            int cityId;
            int parkingArea;
            int productId;
            int num;
            do
            {
                Console.WriteLine("\n\tAdd data to table");
                Console.WriteLine("1 - Category");
                Console.WriteLine("2 - City");
                Console.WriteLine("3 - Country");
                Console.WriteLine("4 - Position");
                Console.WriteLine("5 - Product");
                Console.WriteLine("6 - Shop");
                Console.WriteLine("7 - Worker");
                Console.WriteLine("0 - Back");
                Console.WriteLine("Enter your option");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("Enter name of category");
                    name = Console.ReadLine();
                    Category category = new Category()
                    {
                        Name = name
                    };
                    db.Categories.Add(category);
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Enter name of city");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter countryId");
                    countryId = int.Parse(Console.ReadLine());
                    City city = new City()
                    {
                        Name = name,
                        CountryId = countryId
                    };
                    db.Cities.Add(city);
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Enter name of country");
                    name = Console.ReadLine();
                    Country country = new Country()
                    {
                        Name = name
                    };
                    db.Countries.Add(country);
                }
                else if (menu == 4)
                {
                    Console.WriteLine("Enter name of position");
                    name = Console.ReadLine();
                    Position position = new Position()
                    {
                        Name = name
                    };
                    db.Positions.Add(position);
                }
                else if (menu == 5)
                {
                    Console.WriteLine("Enter name of product");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter price of product");
                    price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter discount of product");
                    discount = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter categoryId of product");
                    categoryId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter quantity of product");
                    quantity = int.Parse(Console.ReadLine());
                    isInStock = true;
                    Product product = new Product()
                    {
                        Name = name,
                        Price = price,
                        Discount = discount,
                        CategoryId = categoryId,
                        Quantity = quantity,
                        IsInStock = isInStock
                    };
                    db.Products.Add(product);
                }
                else if (menu == 6)
                {
                    Console.WriteLine("Enter name of shop");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter address of shop");
                    address = Console.ReadLine();
                    Console.WriteLine("Enter cityId of shop");
                    cityId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter parking area of shop");
                    parkingArea = int.Parse(Console.ReadLine());
                    Shop shop = new Shop()
                    {
                        Name = name,
                        Address = address,
                        CityId = cityId,
                        ParkingArea = parkingArea
                    };
                    Console.WriteLine("Enter number of product you want add to this shop ");
                    num = int.Parse(Console.ReadLine());
                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine("Enter product ID ");
                        productId = int.Parse(Console.ReadLine());
                        var product = db.Products.Find(productId);
                        shop.Products.Add(product);
                    }
                    db.Shops.Add(shop);
                }
                else if (menu == 7)
                {
                    Console.WriteLine("Enter name of worker");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter surname of worker");
                    surname = Console.ReadLine();
                    Console.WriteLine("Enter salary of worker");
                    salary = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter email of worker");
                    email = Console.ReadLine();
                    Console.WriteLine("Enter phone number of worker");
                    phoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter postionId of worker");
                    positionId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter shopId of worker");
                    shopId = int.Parse(Console.ReadLine());
                    Worker worker = new Worker()
                    {
                        Name = name,
                        Surname = surname,
                        Salary = salary,
                        Email = email,
                        PhoneNumber = phoneNumber,
                        PositionId = positionId,
                        ShopId = shopId
                    };
                    db.Workers.Add(worker);
                }
                else if (menu == 0)
                {
                    break;
                }
                else
                    continue;
                db.SaveChanges();
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
            } while (menu != 0);
        }
    }
}