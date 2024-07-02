using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private TextBox _ActiveTextBox;
        public CalculatorForm()
        {
            InitializeComponent();
            _ActiveTextBox = textBox_input1;
        }

        private void textBox_input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_input1_Click(object sender, EventArgs e)
        {
            _ActiveTextBox = (TextBox)sender;
        }

        private void textBox_input2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_input2_Click(object sender, EventArgs e)
        {
            _ActiveTextBox = (TextBox)sender;
        }

        private void button_operatorActive(object sender, EventArgs e)
        {
            comboBox_operators.SelectedItem = ((Button)sender).Text;
        }
        private void add_byButtons(object sender, EventArgs e)
        {
            _ActiveTextBox.Text += ((Button)sender).Text;
        }
    }
}
