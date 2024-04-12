using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClothesShop.Model
{
    public class Clothes : Goods
    {
        public string typeofclothes;
        public string size;
        public string Typeofclothes { get; set; }
        public int Size { get; set; }
        public Clothes(string name, string brand, string color, string
       typeofclothes, int size, double price)
        {
            Name = name;
            Brand = brand;
            Color = color;
            Typeofclothes = typeofclothes;
            Size = size;
            Price = price;
        }
        public override string ToString()
        {
            return ("Наименование: " + this.Name + "\nПроизводитель: " + this.Brand + "\nЦвет: "
           +
            this.Color + "\n Категория одежды: " + this.Typeofclothes +
           "\n размер: " +
            this.Size + "\nЦена: " + this.Price + " руб");
        }
    }
}
