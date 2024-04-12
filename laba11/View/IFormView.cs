using ClothesShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.View
{
    public interface IFormView
    {
        void SetDataSource(List<Goods> dataSource);
  
        void DisplayMessage(string message);
        void UpdateOrderSummary(double totalAmount);

    }
}
