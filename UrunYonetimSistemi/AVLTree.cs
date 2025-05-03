using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AVLTreeInventory
{
    public class TreeNode
    {
        public Product Product;
        public TreeNode Left;
        public TreeNode Right;
        public int Height;

        public TreeNode(Product product)
        {
            Product = product;
            Height = 1;
        }
    }

    public class AVLTree
    {
        private TreeNode root;

        private int Height(TreeNode node) => node?.Height ?? 0;

        private int GetBalance(TreeNode node) => node == null ? 0 : Height(node.Left) - Height(node.Right);

        private TreeNode RotateRight(TreeNode y)
        {
            TreeNode x = y.Left;
            TreeNode T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            y.Height = 1 + Math.Max(Height(y.Left), Height(y.Right));
            x.Height = 1 + Math.Max(Height(x.Left), Height(x.Right));

            return x;
        }

        private TreeNode RotateLeft(TreeNode x)
        {
            TreeNode y = x.Right;
            TreeNode T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            x.Height = 1 + Math.Max(Height(x.Left), Height(x.Right));
            y.Height = 1 + Math.Max(Height(y.Left), Height(y.Right));

            return y;
        }

        private TreeNode Insert(TreeNode node, Product product)
        {
            if (node == null) return new TreeNode(product);

            if (product.Price < node.Product.Price)
                node.Left = Insert(node.Left, product);
            else if (product.Price > node.Product.Price)
                node.Right = Insert(node.Right, product);
            else
                return node;

            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
            int balance = GetBalance(node);

            if (balance > 1 && product.Price < node.Left.Product.Price)
                return RotateRight(node);
            if (balance < -1 && product.Price > node.Right.Product.Price)
                return RotateLeft(node);
            if (balance > 1 && product.Price > node.Left.Product.Price)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }
            if (balance < -1 && product.Price < node.Right.Product.Price)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        public Product SearchByName(string name)
        {
            return SearchByNameHelper(root, name);
        }

        private Product SearchByNameHelper(TreeNode node, string name)
        {
            if (node == null)
                return null;

            if (node.Product.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return node.Product;

            var leftResult = SearchByNameHelper(node.Left, name);
            if (leftResult != null)
                return leftResult;

            return SearchByNameHelper(node.Right, name);
        }


        public void Insert(Product product) => root = Insert(root, product);

        public List<Product> InOrderToList()
        {
            var list = new List<Product>();
            InOrder(root, list);
            return list;
        }

        private void InOrder(TreeNode node, List<Product> list)
        {
            if (node == null) return;
            InOrder(node.Left, list);
            list.Add(node.Product);
            InOrder(node.Right, list);
        }
    }
}
