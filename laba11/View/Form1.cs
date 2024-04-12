using ClothesShop.Model;
using ClothesShop.Presenter;
using ClothesShop.View;

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using laba11.Presenter;



namespace laba11
{
    public partial class Form1 : Form, IPresenter

    {

        
        private  MainPresenter presenter;
        public Form1()
        {
            presenter = new MainPresenter(this);
            //вот тут мы пихаем наши вводы и выводы в презентер
            InitializeComponent();

        }
        
        public string name
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }
        public string brand
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string color
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string type
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        
        public int size
        {
            get { return (int)numericUpDown1.Value; }
            set { textBox5.Text = value.ToString(); }
        }
        public double price
        {
            get { return Convert.ToDouble(textBox5.Text); }
            set { textBox5.Text = value.ToString(); }
        }
        public string DelInfo
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }
        // вот о чем в мэйн презентере сказано - вот так как сверху задаешь ввод и вывод
        public void SetDataSource(List<Goods> dataSource)
        {
            // это вроде твой дата сурс для листбокса, сурс скорее всего надо будет пихать в презентере, а тут вызывать метод для этого(или вообще не вызывать,чисто в презентере все делать,хз)
        }

        
        private void AddClothes_Button_Click(object sender, EventArgs e)
        {
            presenter.AddClothes();

            presenter.UpdateOrderSummary(Convert.ToDouble(textBox5.Text));
        }

        private void AddShoes_Button_Click(object sender, EventArgs e)
        {
            presenter.AddShoes();
            presenter.UpdateOrderSummary(Convert.ToDouble(textBox5.Text));
        }

        private void AddAccessories_Button_Click(object sender, EventArgs e)
        {
            presenter.AddAccessories();
            presenter.UpdateOrderSummary(Convert.ToDouble(textBox5.Text));
        }
        //это понятно чо вызываю методы твоего презентера, которые вызывают классы модели, тут во view классов модели не должно быть

        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void UpdateOrderSummary(double totalAmount)
        {
           
        }


        private void DeliveriInfo_Button_Click(object sender, EventArgs e)
        {          
           presenter.ShowDelivery(); 
            //это то что я не доделал, тут двоятся текстбоксы
        }

       
    }
}
