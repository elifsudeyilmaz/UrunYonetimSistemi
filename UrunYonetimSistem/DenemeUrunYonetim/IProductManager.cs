using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeUrunYonetim
{
    // IProductManager.cs
    // Ürün yönetim işlemleri için arayüz

    public interface IProductManager
    {
        void AddProduct(Product p);
        void RemoveProduct(int id);
        void UpdateProduct(Product p);
    }
}
