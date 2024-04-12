using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Model
{
    public interface ISellable
    {
        double Price { get; set; }
        double Sale(double price);
    }
}
