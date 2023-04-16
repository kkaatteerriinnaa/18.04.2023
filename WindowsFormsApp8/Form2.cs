using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form1 MainForm1 { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        private void fuelTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFuelType = fuelTypes[fuelTypeComboBox.SelectedIndex];
            fuelPriceLabel.Text = selectedFuelType.Price.ToString("C");
            radioButtonLiters.Checked = true;
            radioButtonAmount.Enabled = true;
            labelGasolineCost.Enabled = false;
            sumRadioButton.Enabled = true;
        }

        // Обработчик выбора способа заправки
        private void litersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonAmount.Enabled = true;
            labelGasolineCost.Enabled = false;
        }

        private void sumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            labelGasolineCost.Enabled = true;
            radioButtonAmount.Enabled = false;
        }
        // Обработчик события при изменении выбранного горючего
        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранный элемент из ComboBox
            string fuelType = fuelTypeComboBox.SelectedItem.ToString();
            // Устанавливаем соответствующую цену в зависимости от выбранного горючего
            if (fuelType == "АИ-95")
            {
                labelFuelPrice.Text = priceGasoline.ToString() + " грн./л";
            }
            else if (fuelType == "Дизель")
            {
                labelFuelPrice.Text = priceDiesel.ToString() + " грн./л";
            }
        }
        // Обработчик события при изменении выбранного способа оплаты
        private void radioButtonPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLiters.Checked)
            {
                // Разблокируем поле для ввода количества литров и блокируем поле для ввода суммы
                fuelPriceLabel.Enabled = true;
                sumRadioButton.Enabled = false;
                labelGasolineCost.Text = "К оплате:";
                labelPaymentUnit.Text = "грн.";
            }
            else if (radioButtonAmount.Checked)
            {
                // Разблокируем поле для ввода суммы и блокируем поле для ввода количества литров
                fuelPriceLabel.Enabled = false;
                sumRadioButton.Enabled = true;
                labelGasolineCost.Text = "К выдаче:";
                labelPaymentUnit.Text = "л";
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.ChildForm1 = null;
        }
    }
}
