using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVLTreeInventory;
using DenemeUrunYonetim;
using WindowsFormsApp1;

namespace UrunEnvanterApp
{
    internal static class Program
    {
        public static class GlobalData
        {
            public static AVLTree avlTree = new AVLTree();
            public static HashTable productTable = new HashTable();
            public static ProductLinkedList linkedList = new ProductLinkedList();
        }
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaFormcs());
        }
    }
}
