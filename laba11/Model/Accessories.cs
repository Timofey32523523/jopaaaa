using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Model
{
    public class Accessories : Goods
    {
        public string typeofaccessories;
        public int size;
        public string Typeofaccessories { get; set; }
        public int Size { get; set; }

        public Accessories(string name, string brand, string color, string
       typeofaccessories, int size, double price)
        {
            Name = name;
            Brand = brand;
            Color = color;
            Typeofaccessories = typeofaccessories;
            Size = size;
            Price = price;
        }
        public override string ToString() //переопределенный метод базового класса
        {
            return ("Название: " + this.Name + "\nБренд: " + this.Brand + "\nЦвет: "
           +
            this.Color + "\n:Вид акссесуара " + this.Typeofaccessories +
           "\nРазмер: " +
            this.Size + "\nЦена: " + this.Price + " руб");
        }
    }
}
