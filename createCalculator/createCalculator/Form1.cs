using System.Data;

namespace createCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calTotal;
        double n1;
        double n2;
        string option;
        double result;
        string expression = "";

        private void button13_Click(object sender, EventArgs e)
        {
            expression += button13.Text;
            richTextBox1.Text = expression;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            expression += button14.Text;
            richTextBox1.Text = expression;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            expression += button15.Text;
            richTextBox1.Text = expression;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            expression += button18.Text;
            richTextBox1.Text = expression;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            expression += button9.Text;
            richTextBox1.Text = expression;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            expression += button10.Text;
            richTextBox1.Text = expression;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            expression += button11.Text;
            richTextBox1.Text = expression;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            expression += button5.Text;
            richTextBox1.Text = expression;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            expression += button6.Text;
            richTextBox1.Text = expression;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            expression += button7.Text;
            richTextBox1.Text = expression;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            expression += "+";
            richTextBox1.Text = expression;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            expression += "-";
            richTextBox1.Text = expression;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            expression += "*";
            richTextBox1.Text = expression;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            expression += "/";
            richTextBox1.Text = expression;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                string expressionToEvaluate = expression.Replace("%", "/100*");
                var result = new DataTable().Compute(expressionToEvaluate, "");
                richTextBox1.Text = result.ToString();
                expression = result.ToString();
            }
            catch
            {
                richTextBox1.Text = "Error";
                expression = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            expression = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expression += "%";
            richTextBox1.Text = expression;
        }
    }
}
