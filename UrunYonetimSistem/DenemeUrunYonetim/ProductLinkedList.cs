using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Ürünleri listeleme
        public void DisplayProducts()
        {
            if (head == null)
            {
                Console.WriteLine("Ürün listesi boş.");
                return;
            }

            ProductNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data.ToString());
                current = current.Next;
            }
        }
    }

}
