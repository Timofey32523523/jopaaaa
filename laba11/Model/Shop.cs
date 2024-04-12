using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Model
{
    public class OnlineShop : ISellable
    {
        public double Price { get; set; }
        public double Summary { get; set; }
        public double Discount { get; set; }
        ISellable sellable;//агрегация
        public OnlineShop(ISellable sel)
        {
            sellable = sel;
        }
        public OnlineShop() : base() { }
        //композиция
        Goods
            goods;

        //перегруженный метод Sale
        public double Sale(double price, double discount)
        {
            if (price > 1000)
            {
                Price = price * (1 - discount);
                Discount = discount;
            }
            else Price = price;
            return Price;
        }
        // Переопределенный метод Sale
        public double Sale(double price)
        {
            Sale(price, 0.2);
            return Price;
        }
        public double Sum(double price)
        {
            Summary += price;
            return Summary;
        }
        public override string ToString()
        {
            return ("\nСтоимость заказа: " + this.Summary + " руб");
        }
        public delegate void SellableHandler(object sender, SellableEvenrArgs e);
        public event SellableHandler Sellable_Note;//объявление события
        public void Add_order(double price)//добавление продукта в заказ
        {
            Sellable_Note.Invoke(this, new SellableEvenrArgs("Стоимость вашего заказа =", Summary));
        }
        public void Done(double price) //конечное сообщение с суммой заказа + цена
        {
            Sellable_Note.Invoke(this, new SellableEvenrArgs("Спасибо за заказ! ", Summary + 200));
        }

    }
}
