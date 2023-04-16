using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        // Список типов горючего
        private List<FuelType> fuelTypes = new List<FuelType>()
        {
            new FuelType("A-92", 24.50m),
            new FuelType("A-95", 26.10m),
            new FuelType("A-98", 29.50m),
            new FuelType("Diesel", 25.0m)
        };

        // Список товаров в кафе
        private List<Product> products = new List<Product>
        {
            new Product("Hamburger", 60.0m),
            new Product("Hot dog", 50.0m),
            new Product("Coca-Cola", 20.0m),
            new Product("Potato", 10.0m),

        };

        // Выбранный тип горючего
        private FuelType selectedFuelType;

        // Выбранный товар
        private Product selectedProduct;

        MainMenu Menu;
        MenuItem m1, m2, m3, subm1;
        int index = 0;

        private void subm(object sender, EventArgs e)
        {
            index++;
            MenuItem item = (MenuItem)sender;
            string fileName = "results.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Клиент " + index);
                writer.WriteLine(fuelTypeComboBox.SelectedItem.ToString());
                writer.WriteLine("Стоимость заправки:" + labelGasolineCost.Text);
                writer.WriteLine("Стоимость кафе:" + labelCafeCost.Text);
                writer.WriteLine("Общая стоимость:" + labelTotalCost.Text);
            }
        }
        private void Quit(object sender, EventArgs e)
        {
            Close();
        }
        private void clear(object sender, EventArgs e)
        {
            fuelTypeComboBox.Items.Clear();
            fuelPriceLabel.Clear();
            sumRadioButton.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }
        public Form1()
        {
            InitializeComponent();

            Menu = new MainMenu();

            m1 = new MenuItem("Клиент");
            Menu.MenuItems.Add(m1);

            subm1 = new MenuItem("Новый клиент");
            subm1.Click += new EventHandler(subm);
            m1.MenuItems.Add(subm1);

            m2 = new MenuItem("Выход");
            Menu.MenuItems.Add(m2);
            m2.Click += new EventHandler(Quit);

            m3 = new MenuItem("Сброс");
            Menu.MenuItems.Add(m3);
            m3.Click += new EventHandler(clear);


            foreach (FuelType fuelType in fuelTypes)
            {
                fuelTypeComboBox.Items.Add(fuelType.Name);
            }
            // Выбор первого элемента в ComboBox и сохранение соответствующего типа горючего
            fuelTypeComboBox.SelectedIndex = 0;
            selectedFuelType = fuelTypes[0];

            // Добавление товаров в кафе в CheckBox'ы
            foreach (Product product in products)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = product.Name + " (" + product.Price.ToString("C") + ")";
                checkBox.CheckedChanged += ProductCheckBox_CheckedChanged;
                cafeGroupBox.Controls.Add(checkBox);
            }

            // Очистка формы
            ClearForm();
        }

        public Form2 ChildForm1 { get; set; }
        public Form3 ChildForm1 { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ChildForm1 != null)
            {
                ChildForm1.Activate();
                return;
            }
            ChildForm1 = new Form2();
            ChildForm1.MainForm = this;
            ChildForm1.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ChildForm2 != null)
            {
                ChildForm2.Activate();
                return;
            }
            ChildForm2 = new Form3();
            ChildForm2.MainForm = this;
            ChildForm2.Show();
        }

        double priceGasoline = 30.50;
        double priceDiesel = 32.20;

        // Обработчик события при нажатии на кнопку "Рассчитать"
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Получаем выбранный элемент из ComboBox
            string fuelType = fuelTypeComboBox.SelectedItem.ToString();

            // Получаем количество литров или сумму для оплаты
            double paymentValue = 0;
            if (radioButtonLiters.Checked)
            {
                paymentValue = Convert.ToDouble(fuelPriceLabel.Text);
            }
            else if (radioButtonAmount.Checked)
            {
                paymentValue = Convert.ToDouble(sumRadioButton.Text) / priceGasoline;
            }

            // Вычисляем стоимость горючего и товаров в кафе
            double gasolineCost = paymentValue * priceGasoline;
            double cafeCost = 0;
            if (checkBox4.Checked)
            {
                cafeCost += 20.50 * Convert.ToInt32(textBox10.Text);
            }
            if (checkBox2.Checked)
            {
                cafeCost += 15.75 * Convert.ToInt32(textBox6.Text);
            }

            // Вычисляем общую сумму к оплате или к выдаче
            double totalCost = gasolineCost + cafeCost;
            {
                // Выводим результаты расчета
                labelGasolineCost.Text = gasolineCost.ToString("F2") + " грн.";
                labelCafeCost.Text = cafeCost.ToString("F2") + " грн.";
                labelTotalCost.Text = totalCost.ToString("F2") + " грн.";

                // Очищаем поля ввода
                fuelTypeComboBox.SelectedIndex = 0;

            }
            // Получаем количество литров или сумму для оплаты
            paymentValue = 0;
            if (radioButtonLiters.Checked)
            {
                paymentValue = Convert.ToDouble(fuelPriceLabel.Text);
            }
            else if (radioButtonAmount.Checked)
            {
                paymentValue = Convert.ToDouble(sumRadioButton.Text) / priceGasoline;
            }

            // Вычисляем стоимость горючего и товаров в кафе
            gasolineCost = paymentValue * priceGasoline;
            cafeCost = 0;
            if (checkBox4.Checked)
            {
                cafeCost += 20.50 * Convert.ToInt32(textBox10.Text);
            }
            if (checkBox2.Checked)
            {
                cafeCost += 15.75 * Convert.ToInt32(textBox6.Text);
            }

            // Вычисляем общую сумму к оплате или к выдаче
            totalCost = gasolineCost + cafeCost;

            // Выводим результаты расчета
            labelGasolineCost.Text = gasolineCost.ToString("F2") + " грн.";
            labelCafeCost.Text = cafeCost.ToString("F2") + " грн.";
            labelTotalCost.Text = totalCost.ToString("F2") + " грн.";

            // Очищаем поля ввода
            fuelTypeComboBox.SelectedIndex = 0;
            // Очищаем поля для нового клиента
            private void ClearFields()
            {
                comboBoxFuelType.SelectedIndex = 0;
                textBoxFuelPrice.Text = fuelPrices[0].ToString("N2");
                textBoxFuelQuantity.Text = "";
                textBoxFuelSum.Text = "";
                radioButtonBySum.Checked = true;
                radioButtonByLiters.Checked = false;
                textBoxSumOrQuantity.Text = "";
                foreach (var product in products)
                {
                    product.IsChecked = false;
                    product.Quantity = 0;
                }
                UpdateProductsList();
                textBoxTotalSum.Text = "";
            }

            // Обновляем список товаров
            private void UpdateProductsList()
            {
                listViewProducts.Items.Clear();
                foreach (var product in products)
                {
                    if (product.IsChecked)
                    {
                        var item = new ListViewItem(new[] { product.Name, product.Quantity.ToString(), product.Price.ToString("N2") });
                        listViewProducts.Items.Add(item);
                    }
                }
            }

            // Рассчитываем итоговую сумму
            private void CalculateTotalSum()
            {
                double fuelSum = 0;
                if (radioButtonBySum.Checked)
                {
                    double fuelQuantity = double.Parse(textBoxSumOrQuantity.Text) / fuelPrices[comboBoxFuelType.SelectedIndex];
                    fuelSum = fuelQuantity * fuelPrices[comboBoxFuelType.SelectedIndex];
                    textBoxFuelQuantity.Text = fuelQuantity.ToString("N2");
                }
                else if (radioButtonByLiters.Checked)
                {
                    double fuelQuantity = double.Parse(textBoxSumOrQuantity.Text);
                    fuelSum = fuelQuantity * fuelPrices[comboBoxFuelType.SelectedIndex];
                    textBoxFuelQuantity.Text = fuelQuantity.ToString("N2");
                }
                textBoxFuelSum.Text = fuelSum.ToString("N2");
                double productsSum = 0;
                foreach (var product in products)
                {
                    productsSum += product.Quantity * product.Price;
                }
                textBoxProductsSum.Text = productsSum.ToString("N2");
                double totalSum = fuelSum + productsSum;
                textBoxTotalSum.Text = totalSum.ToString("N2");
            }

            // Обрабатываем нажатие кнопки "Оплатить"
            private void buttonPay_Click(object sender, EventArgs e)
            {
                CalculateTotalSum();
                var result = MessageBox.Show("Очистить форму?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ClearFields();
                    totalSales += double.Parse(textBoxTotalSum.Text);
                }
                else
                {
                    Thread.Sleep(10000);
                    ClearFields();
                    totalSales += double.Parse(textBoxTotalSum.Text);
                }
            }

            // Обрабатываем закрытие формы
            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                e.Cancel = true;
                var result = MessageBox.Show("Вы действительно хотите выйти? Все несохраненные данные будут утеряны.", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                    MessageBox.Show("Общая сумма выручки за день: " + totalSales.ToString("N2"), "Выход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
