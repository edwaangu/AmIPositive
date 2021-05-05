using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmIPositive
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(inputBox.Text);
            if(num >= 0)
            {
                negativeNumberOutput.Text = $"{num} is a positive number";
            }
            else
            {
                negativeNumberOutput.Text = $"{num} is a negative number";
            }
            if(num % 7 == 0 && num != 0)
            {
                divisibleBy7Output.Text = $"{num} is divisble by 7";
            }
            else
            {
                divisibleBy7Output.Text = $"{num} is not divisble by 7";
            }
        }
    }
}
