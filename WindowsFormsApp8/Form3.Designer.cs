
namespace WindowsFormsApp8
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelGasolineCost = new System.Windows.Forms.Label();
            this.labelPaymentUnit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFuelPrice = new System.Windows.Forms.TextBox();
            this.fuelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonAmount = new System.Windows.Forms.RadioButton();
            this.radioButtonLiters = new System.Windows.Forms.RadioButton();
            this.sumRadioButton = new System.Windows.Forms.TextBox();
            this.fuelPriceLabel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelFuelPrice);
            this.groupBox1.Controls.Add(this.fuelTypeComboBox);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Location = new System.Drawing.Point(277, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 336);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заправка";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.labelGasolineCost);
            this.groupBox4.Controls.Add(this.labelPaymentUnit);
            this.groupBox4.Location = new System.Drawing.Point(6, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "К оплате";
            // 
            // labelGasolineCost
            // 
            this.labelGasolineCost.AutoSize = true;
            this.labelGasolineCost.Location = new System.Drawing.Point(139, 75);
            this.labelGasolineCost.Name = "labelGasolineCost";
            this.labelGasolineCost.Size = new System.Drawing.Size(25, 13);
            this.labelGasolineCost.TabIndex = 11;
            this.labelGasolineCost.Text = "про";
            // 
            // labelPaymentUnit
            // 
            this.labelPaymentUnit.AutoSize = true;
            this.labelPaymentUnit.Location = new System.Drawing.Point(195, 75);
            this.labelPaymentUnit.Name = "labelPaymentUnit";
            this.labelPaymentUnit.Size = new System.Drawing.Size(27, 13);
            this.labelPaymentUnit.TabIndex = 11;
            this.labelPaymentUnit.Text = "грн.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бензин";
            // 
            // labelFuelPrice
            // 
            this.labelFuelPrice.Location = new System.Drawing.Point(102, 56);
            this.labelFuelPrice.Name = "labelFuelPrice";
            this.labelFuelPrice.ReadOnly = true;
            this.labelFuelPrice.Size = new System.Drawing.Size(121, 20);
            this.labelFuelPrice.TabIndex = 0;
            // 
            // fuelTypeComboBox
            // 
            this.fuelTypeComboBox.FormattingEnabled = true;
            this.fuelTypeComboBox.Location = new System.Drawing.Point(102, 19);
            this.fuelTypeComboBox.Name = "fuelTypeComboBox";
            this.fuelTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.fuelTypeComboBox.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox6.Controls.Add(this.radioButtonAmount);
            this.groupBox6.Controls.Add(this.radioButtonLiters);
            this.groupBox6.Controls.Add(this.sumRadioButton);
            this.groupBox6.Controls.Add(this.fuelPriceLabel);
            this.groupBox6.Location = new System.Drawing.Point(6, 127);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(234, 68);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // radioButtonAmount
            // 
            this.radioButtonAmount.AutoSize = true;
            this.radioButtonAmount.Location = new System.Drawing.Point(6, 38);
            this.radioButtonAmount.Name = "radioButtonAmount";
            this.radioButtonAmount.Size = new System.Drawing.Size(51, 17);
            this.radioButtonAmount.TabIndex = 11;
            this.radioButtonAmount.TabStop = true;
            this.radioButtonAmount.Text = "Цена";
            this.radioButtonAmount.UseVisualStyleBackColor = true;
            // 
            // radioButtonLiters
            // 
            this.radioButtonLiters.AutoSize = true;
            this.radioButtonLiters.Location = new System.Drawing.Point(5, 15);
            this.radioButtonLiters.Name = "radioButtonLiters";
            this.radioButtonLiters.Size = new System.Drawing.Size(59, 17);
            this.radioButtonLiters.TabIndex = 11;
            this.radioButtonLiters.TabStop = true;
            this.radioButtonLiters.Text = "Кол-во";
            this.radioButtonLiters.UseVisualStyleBackColor = true;
            // 
            // sumRadioButton
            // 
            this.sumRadioButton.Location = new System.Drawing.Point(96, 41);
            this.sumRadioButton.Name = "sumRadioButton";
            this.sumRadioButton.Size = new System.Drawing.Size(121, 20);
            this.sumRadioButton.TabIndex = 3;
            // 
            // fuelPriceLabel
            // 
            this.fuelPriceLabel.Location = new System.Drawing.Point(96, 15);
            this.fuelPriceLabel.Name = "fuelPriceLabel";
            this.fuelPriceLabel.Size = new System.Drawing.Size(121, 20);
            this.fuelPriceLabel.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelGasolineCost;
        private System.Windows.Forms.Label labelPaymentUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelFuelPrice;
        private System.Windows.Forms.ComboBox fuelTypeComboBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButtonAmount;
        private System.Windows.Forms.RadioButton radioButtonLiters;
        private System.Windows.Forms.TextBox sumRadioButton;
        private System.Windows.Forms.TextBox fuelPriceLabel;
    }
}