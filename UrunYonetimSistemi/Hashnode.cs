﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using AVLTreeInventory;
using DenemeUrunYonetim;


namespace WindowsFormsApp1
{
    internal class HashNode
    {
        public Product Product;
        public HashNode Next;

        public HashNode(Product product)
        {
            Product = product;
            Next = null;
        }
    }
}
