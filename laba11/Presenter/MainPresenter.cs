
using ClothesShop.Model;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ClothesShop.View;
using laba11.Presenter;

namespace ClothesShop.Presenter
{
    public class MainPresenter
    {
        IPresenter present;
        public MainPresenter(IPresenter pres)
        {
            present = pres;
            this.GoodsList = new List<Goods>();
            this.shop = new OnlineShop();
        }
        //это мы типа подключаем наш интерфейс для обмена с вью
        
        private List<Goods> GoodsList;
        private OnlineShop shop;
        // это я хз как работает, видимо ты в ричтекстбокс выводишь список. Либо переделаешь его (я уже че то вроде переделал с ним немного), либо тупо печатай как я печатал, ниже пример
        //Present.Sended += string.Format("Количество персонала на Земле: {0}, Отправлено персонала: {1}, Дата и время отправки: {2}, на планету:{3}, Log: {4}\n\n", spc.Resources.ToString(), mks.Resources.ToString(), DateTime.Now, Present.PlanetName, Present.Log);
        // вот так типа через стринг формат sended это у меня ричтекстбокс, я туда так вывожу
        public void SetOnlineShop(OnlineShop shop)
        {
            this.shop = shop;
            //вот на это ссылок че то нету, либо дело в модели, либо это старая какашка, которую гуков и ругал
        }

        public void DisplayMessage(string message)
        {
            DisplayMessage(message);

        }
        public void UpdateOrderSummary(double totalAmount)
        {
            UpdateOrderSummary(totalAmount);
            shop.Sale(totalAmount);
            shop.Sum(totalAmount);
            shop.Add_order(totalAmount);
        }
        public void AddGoods(Goods goods)
        {
            GoodsList.Add(goods);
            //view.SetDataSource(GoodsList);
        }
        // ниже переписал твои методы, тк они не должны в аргументы че то принимать, вместо этого мы через интерфейс обмениваемся
        public void AddClothes()
        {
            Clothes clothes = new Clothes(present.name, present.brand, present.color, present.type, present.size,
            present.price);
            AddGoods(clothes);
        }
        public void AddShoes()
        {
            Shoes shoes = new Shoes(present.name, present.brand, present.color, present.type, present.size,
          present.price);
            AddGoods(shoes);
        }

        public void AddAccessories()
        {
            Accessories accessories = new Accessories(present.name, present.brand, present.color, present.type, present.size,
           present.price);
            AddGoods(accessories);
        }
        public void ShowDelivery()
        {
            //тут задваивается текстбокс, надо будет сделать свойство в интерфейсе для каждого вводного и выводного элемента который ты будешь использовать и внедрить в view, например как я сделал size, brand и тд, по их образу делаешь че угодно - и лейблы и листбоксы и ричтекстбоксы
//            Delivery delivery = new Delivery(comboBox1.Text, dateTimePicker1.Value,
//textBox5.Text);
//            present.DelInfo += string.Format();
// закомментил пушто надо исправить в модели, стринг формат я написал чтобы туда потом вывести инфу о доставке по аналогии как выше из моего примера
        }
    }
 }
