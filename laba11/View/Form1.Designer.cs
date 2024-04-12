using System;

namespace laba11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddClothes_Button = new System.Windows.Forms.Button();
            this.AddShoes_Button = new System.Windows.Forms.Button();
            this.AddAccessories_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DeliveriInfo_Button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LB1 = new System.Windows.Forms.Label();
            this.FinalInfo_Button = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddClothes_Button
            // 
            this.AddClothes_Button.Location = new System.Drawing.Point(35, 303);
            this.AddClothes_Button.Name = "AddClothes_Button";
            this.AddClothes_Button.Size = new System.Drawing.Size(75, 23);
            this.AddClothes_Button.TabIndex = 0;
            this.AddClothes_Button.Text = "Добавить одежду";
            this.AddClothes_Button.UseVisualStyleBackColor = true;
            this.AddClothes_Button.Click += new System.EventHandler(this.AddClothes_Button_Click);
            // 
            // AddShoes_Button
            // 
            this.AddShoes_Button.Location = new System.Drawing.Point(35, 345);
            this.AddShoes_Button.Name = "AddShoes_Button";
            this.AddShoes_Button.Size = new System.Drawing.Size(75, 23);
            this.AddShoes_Button.TabIndex = 1;
            this.AddShoes_Button.Text = "Добавить обувь";
            this.AddShoes_Button.UseVisualStyleBackColor = true;
            this.AddShoes_Button.Click += new System.EventHandler(this.AddShoes_Button_Click);
            // 
            // AddAccessories_Button
            // 
            this.AddAccessories_Button.Location = new System.Drawing.Point(35, 415);
            this.AddAccessories_Button.Name = "AddAccessories_Button";
            this.AddAccessories_Button.Size = new System.Drawing.Size(75, 23);
            this.AddAccessories_Button.TabIndex = 2;
            this.AddAccessories_Button.Text = "Добавить аксессуар";
            this.AddAccessories_Button.UseVisualStyleBackColor = true;
            this.AddAccessories_Button.Click += new System.EventHandler(this.AddAccessories_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(35, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(35, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(35, 211);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(35, 260);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(289, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 9;
            // 
            // DeliveriInfo_Button
            // 
            this.DeliveriInfo_Button.Location = new System.Drawing.Point(343, 303);
            this.DeliveriInfo_Button.Name = "DeliveriInfo_Button";
            this.DeliveriInfo_Button.Size = new System.Drawing.Size(75, 23);
            this.DeliveriInfo_Button.TabIndex = 10;
            this.DeliveriInfo_Button.Text = "Инф о доставка";
            this.DeliveriInfo_Button.UseVisualStyleBackColor = true;
            this.DeliveriInfo_Button.Click += new System.EventHandler(this.DeliveriInfo_Button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(545, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Tag = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(545, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(555, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Location = new System.Drawing.Point(158, 19);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(44, 16);
            this.LB1.TabIndex = 14;
            this.LB1.Text = "label1";
            // 
            // FinalInfo_Button
            // 
            this.FinalInfo_Button.Location = new System.Drawing.Point(343, 344);
            this.FinalInfo_Button.Name = "FinalInfo_Button";
            this.FinalInfo_Button.Size = new System.Drawing.Size(75, 23);
            this.FinalInfo_Button.TabIndex = 15;
            this.FinalInfo_Button.Text = "btn_FinalMessage";
            this.FinalInfo_Button.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinalInfo_Button);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DeliveriInfo_Button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddAccessories_Button);
            this.Controls.Add(this.AddShoes_Button);
            this.Controls.Add(this.AddClothes_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        


        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button AddClothes_Button;
        private System.Windows.Forms.Button AddShoes_Button;
        private System.Windows.Forms.Button AddAccessories_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DeliveriInfo_Button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.Button FinalInfo_Button;
        private System.Data.DataSet dataSet1;
    }
}

