using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTreeInventory
{
    public class AVLNode
    {
        public Product Product { get; set; }
        public AVLNode Left { get; set; }
        public AVLNode Right { get; set; }
        public int Height { get; set; }

        public AVLNode(Product product)
        {
            Product = product;
            Height = 1;
        }
    }
}
