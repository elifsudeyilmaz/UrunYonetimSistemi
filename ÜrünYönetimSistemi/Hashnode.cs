using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;


namespace WindowsFormsApp1
{
    internal class HashNode
    {
        public Products Product;
        public HashNode Next;

        public HashNode(Products product)
        {
            Product = product;
            Next = null;
        }
    }
}
