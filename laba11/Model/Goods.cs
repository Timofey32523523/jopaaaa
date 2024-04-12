using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Model
{
    abstract public class Goods //создание абстрактного класса
    {
        public string name;
        public string brand;
        public string color;
        public string photo;
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
    }
}
