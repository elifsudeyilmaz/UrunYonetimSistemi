using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeUrunYonetim
{
    // ProductNode.cs
    // LinkedList içinde kullanılacak ürün düğümü (Node)

    public class ProductNode
    {
        public Product Data { get; set; }
        public ProductNode Next { get; set; }

        public ProductNode(Product data)
        {
            Data = data;
            Next = null;
        }
    }

}
