using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberBox_ValueChanged(object sender, EventArgs e)
        {
            Double sum = 0;

            Double oneCent = 0.01 * (Double)OneCent.Value;
            Double twoCent= 0.02 * (Double)TwoCent.Value;
            Double fiveCent = 0.05 * (Double)FiveCent.Value;
            Double tenCent = 0.1 * (Double)TenCent.Value;
            Double twentyCent= 0.2 * (Double)TwentyCent.Value;
            Double fiftyCent= 0.5 * (Double)FiftyCent.Value;
            Double oneEuro= 1 * (Double)OneEuro.Value;
            Double twoEuro = 2 * (Double)TwoEuro.Value;
            Double fiveEuro = 5 * (Double)FiveEuro.Value;
            Double tenEuro = 10 * (Double)TenEuro.Value;
            Double twentyEuro = 20 * (Double)TwentyEuro.Value;
            Double fiftyEuro= 50 * (Double)FiftyEuro.Value;
            Double oneHundredEuro = 100 * (Double)OneHundredEuro.Value;
            Double twoHundredEuro = 200 * (Double)TwoHundredEuro.Value;

            LblOneCent.Text = oneCent.ToString();
            LblTwoCent.Text = twoCent.ToString();
            LblFiveCent.Text = fiveCent.ToString();
            LblTenCent.Text = tenCent.ToString();
            LblTwentyCent.Text = twentyCent.ToString();
            LblFiftyCent.Text = fiftyCent.ToString();
            LblOneEuro.Text = oneEuro.ToString();
            LblTwoEuro.Text = twoEuro.ToString();
            LblFiveEuro.Text = fiveEuro.ToString();
            LblTenEuro.Text = tenEuro.ToString();
            LblTwentyEuro.Text = twentyEuro.ToString();
            LblFiftyEuro.Text = fiftyEuro.ToString();
            LblOneHundredEuro.Text = oneHundredEuro.ToString();
            LblTwoHundredEuro.Text = twoHundredEuro.ToString();

            sum = oneCent + twoCent + fiveCent + tenCent + twentyCent + fiftyCent;
            sum += oneEuro + twoEuro + fiveEuro + tenEuro + twentyEuro + fiftyEuro + oneHundredEuro + twoHundredEuro;
            TotalBox.Text = sum.ToString();
        }

        private void ClearTotal_Click(object sender, EventArgs e)
        {
            OneCent.Value = 0;
            TwoCent.Value = 0;
            FiveCent.Value = 0;
            TenCent.Value = 0;
            TwentyCent.Value = 0;
            FiftyCent.Value = 0;
            OneEuro.Value = 0;
            TwoEuro.Value = 0;
            FiveEuro.Value = 0;
            TenEuro.Value = 0;
            TwentyEuro.Value = 0;
            FiftyEuro.Value = 0;
            OneHundredEuro.Value = 0;
            TwoHundredEuro.Value = 0;
        }
    }
}
