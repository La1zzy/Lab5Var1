using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Var1Task1
{
    public partial class Form1 : Form
    {
        private const double BasePrice = 20000;
        private const double TurbinePrice = 50000;
        private const double SpoilerPrice = 5000;
        private const double ExhaustsystemPrice = 25000;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            double totalCost = BasePrice;

            if (checkBoxSpoiler.Checked)
                totalCost += SpoilerPrice;

            if (checkBoxTurbine.Checked)
                totalCost += TurbinePrice;

            if (checkBoxExhaustsystem.Checked)
                totalCost += ExhaustsystemPrice;

            MessageBox.Show($"Вартість автомобіля: {totalCost:N2}", "Розрахування вартості", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (totalCost > BasePrice)
            {
                pictureBoxCar.Image = Properties.Resources.Coolcar;
            }
            else
            {
                pictureBoxCar.Image = Properties.Resources.badcar;
            }
        }
    }
}
