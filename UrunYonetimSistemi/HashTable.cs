using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using System.Diagnostics;
using System.Windows.Forms;
using AVLTreeInventory;
using DenemeUrunYonetim;

namespace WindowsFormsApp1
{
    internal class HashTable
    {
        private HashNode[] buckets;
        private int size;

        public HashTable(int size = 100)
        {
            this.size = size;
            buckets = new HashNode[size];
        }

        private int HashFunction(int key) => key % size;

        public void Add(Product product)
        {
            int index = HashFunction(product.ID);
            var newNode = new HashNode(product);

            if (buckets[index] == null)
            {
                buckets[index] = newNode;
            }
            else
            {
                var current = buckets[index];
                HashNode previous = null;

               
                while (current != null)
                {
                    if (current.Product.ID == product.ID)
                    {
                        current.Product = product; 
                        return; 
                    }

                    previous = current;
                    current = current.Next;
                }

              
                previous.Next = newNode;
            }
        }


        public Product Search(int id)
        {
            int index = HashFunction(id);
            var current = buckets[index];
            while (current != null)
            {
                if (current.Product.ID == id)
                    return current.Product;
                current = current.Next;
            }
            return null;
        }

        public bool Delete(int id)
        {
            int index = HashFunction(id);
            var current = buckets[index];
            HashNode prev = null;

            while (current != null)
            {
                if (current.Product.ID == id)
                {
                    if (prev == null)
                        buckets[index] = current.Next;
                    else
                        prev.Next = current.Next;
                    return true;
                }
                prev = current;
                current = current.Next;
            }
            return false;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();
            foreach (var bucket in buckets)
            {
                var current = bucket;
                while (current != null)
                {
                    list.Add(current.Product);
                    current = current.Next;
                }
            }
            return list;
        }
        public void PerformBigDataTest(HashTable productTable, int itemCount)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random rnd = new Random();

            stopwatch.Start();

            for (int i = 0; i < itemCount; i++)
            {
                int id = rnd.Next(1, itemCount * 10);
                Product p = new Product(
                    id,
                    "Ürün" + id,
                    "Kategori" + (id % 5),
                    rnd.Next(10, 1000),   // Price
                    rnd.Next(1, 100)      // Stock
                );

                productTable.Add(p);
            }

            stopwatch.Stop();
            MessageBox.Show($"Eklenen ürün sayısı: {itemCount}\nToplam süre: {stopwatch.ElapsedMilliseconds} ms");
        }

        public void PerformSearchTest(HashTable productTable, int searchCount, int idRange)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random rnd = new Random();
            int found = 0;

            stopwatch.Start();

            for (int i = 0; i < searchCount; i++)
            {
                int id = rnd.Next(1, idRange);
                var result = productTable.Search(id);
                if (result != null)
                    found++;
            }

            stopwatch.Stop();

            MessageBox.Show(
                $"Toplam Arama: {searchCount}\n" +
                $"Bulunan Ürün: {found}\n" +
                $"Toplam Süre: {stopwatch.ElapsedMilliseconds} ms");

        }
        public void PerformDeleteTest(int deleteCount, int idRange)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random rnd = new Random();
            int deleted = 0;

            stopwatch.Start();

            for (int i = 0; i < deleteCount; i++)
            {
                int id = rnd.Next(1, idRange);
                bool result = this.Delete(id); 
                if (result)
                    deleted++;
            }

            stopwatch.Stop();

            MessageBox.Show(
                $"Toplam Silme Denemesi: {deleteCount}\n" +
                $"Başarıyla Silinen: {deleted}\n" +
                $"Toplam Süre: {stopwatch.ElapsedMilliseconds} ms"
            );
        }



    }
}
