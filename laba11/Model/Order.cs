using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Model
{
    public class Delivery
    {
        public string deliverytype;
        public string deliverytown;
        public DateTime DeliveryDate { get; }
        public string DeliveryType { get; set; }
        public string DeliveryTown { get; set; }
        public Delivery() : base() { }
        public Delivery(string deliverytype, DateTime deliveryDate, string
       deliverytown)
        {
            DeliveryType = deliverytype;
            DeliveryTown = deliverytown;
            DeliveryDate = deliveryDate;
        }
        public OnlineShop onlineShop;//ассоциация
        public override string ToString()
        {
            return ("Тип доставки: " + this.DeliveryType + "\nДата доставки: " +
           this.DeliveryDate + "\nГород доставки: " + this.DeliveryTown);
        }
    }
    public class SellableEvenrArgs : EventArgs //класс для данных события
    {
        public string message { get; }
        public double price { get; }
        public SellableEvenrArgs(string message, double price)
        {
            this.message = message;
            this.price = price;
        }
    }
}
