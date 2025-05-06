using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVLTreeInventory;

namespace DenemeUrunYonetim
{
    // ProductLinkedList.cs
    // Ürünleri bağlı liste (LinkedList) şeklinde tutar ve yönetir

    public class ProductLinkedList
    {
        private ProductNode head;

        public ProductLinkedList()
        {
            head = null;
        }

        // Ürün ekleme
        public void AddProduct(Product product)
        {
            ProductNode newNode = new ProductNode(product);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                ProductNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Stok miktarına göre sıralı ekleme
        public void InsertSortedByStock(Product product)
        {
            ProductNode newNode = new ProductNode(product);

            if (head == null || head.Data.Stock >= product.Stock)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            ProductNode current = head;
            while (current.Next != null && current.Next.Data.Stock < product.Stock)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }


        public bool Delete(int id)
        {
            ProductNode current = head;
            ProductNode previous = null;

            while (current != null)
            {
                if (current.Data.ID == id)
                {
                    if (previous == null)
                        head = current.Next;
                    else
                        previous.Next = current.Next;

                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        // Listeyi döndürme
        public List<Product> ToList()
        {
            List<Product> productList = new List<Product>();
            ProductNode current = head;

            while (current != null)
            {
                productList.Add(current.Data);
                current = current.Next;
            }

            return productList;
        }
        public bool UpdateStock(int id, int newStock)
        {
            ProductNode current = head;
            while (current != null)
            {
                if (current.Data.ID == id)
                {
                    current.Data.Stock = newStock;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        // ✅ Yeni: Stoka göre sıralanmış liste döndür
        public List<Product> SortByStock()
        {
            List<Product> unsortedList = ToList();
            return unsortedList.OrderBy(p => p.Stock).ToList();
        }
    }

}
