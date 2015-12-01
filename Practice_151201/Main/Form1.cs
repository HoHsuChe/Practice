using practiceLibrary01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Conponent a = new Conponent();
            Conponent b = new Conponent();
            Conponent c = new Conponent();

            bool isnumber1TransferOK = double.TryParse(numberTextBox1.Text, out a.number1);
            bool isnumber2TransferOK = double.TryParse(numberTextBox2.Text, out b.number2);
            bool isnumber3TransferOK = double.TryParse(numberTextBox3.Text, out c.number3);

            if (isnumber1TransferOK && isnumber2TransferOK)
            {
                numberTextBox3.Text = (a.number1 + a.number2).ToString();
                numberTextBox4.Text = (numberTextBox1.Text + numberTextBox2.Text);
                MessageBox.Show("輸入正確,運算成功!!");
            }
            else if (!isnumber1TransferOK)
            {
                MessageBox.Show("數字1格式錯誤，請重新輸入");
            }
            else if (!isnumber2TransferOK)
            {
                MessageBox.Show("數字2格式錯誤，請重新輸入");
            }
        }
    }
}