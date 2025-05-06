using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Program.cs
// Kullanıcıdan veri alıp yönetimi sağlayan ana program

namespace DenemeUrunYonetim
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductLinkedList productList = new ProductLinkedList();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Ürün Envanter Yönetimi ---");
                Console.WriteLine("1. Ürün Ekle");
                Console.WriteLine("2. Ürünleri Listele");
                Console.WriteLine("3. Çıkış");
                Console.Write("Seçiminiz: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewProduct(productList);
                        break;
                    case "2":
                        productList.DisplayProducts();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Tekrar deneyin.");
                        break;
                }
            }
        }

        static void AddNewProduct(ProductLinkedList productList)
        {
            Console.Write("Ürün ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Ürün Adı: ");
            string name = Console.ReadLine();

            Console.Write("Kategori: ");
            string category = Console.ReadLine();

            Console.Write("Fiyat: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Stok Adedi: ");
            int stock = int.Parse(Console.ReadLine());

            Product newProduct = new Product(id, name, category, price, stock);
            productList.AddProduct(newProduct);

            Console.WriteLine("Ürün başarıyla eklendi!");
        }
    }
}
