using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Model
{
    public class Shoes : Goods
    {
        public string typeofshoes;
        public string size;
        public string Typeofshoes { get; set; }
        public int Size { get; set; }
        public Shoes() { }
        public Shoes(string name, string brand, string color, string
       typeofshoes, int size, double price)
        {
            Name = name;
            Brand = brand;
            Color = color;
            Typeofshoes = typeofshoes;
            Size = size;
            Price = price;
        }
        public override string ToString()
        {
            return ("Название: " + this.Name + "\nБренд: " + this.Brand + "\nЦвет: "
           +
            this.Color + "\nМодель обуви: " + this.Typeofshoes +
           "\nРазмер: " +
            this.Size + "\nЦена: " + this.Price + " руб");
        }
    }

}
