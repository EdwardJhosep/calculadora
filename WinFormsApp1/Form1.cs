namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        char operacion = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//suma 
        {
            valor1 = double.Parse(textBox1.Text);
            operacion = '+';
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)//resta
        {
            valor1 = double.Parse(textBox1.Text);
            operacion = '-';
            textBox1.Clear();

        }

        private void button3_Click(object sender, EventArgs e)//multiplicacion
        {
            valor1 = double.Parse(textBox1.Text);
            operacion = '*';
            textBox1.Clear();

        }

        private void button4_Click(object sender, EventArgs e)//division
        {
            valor1 = double.Parse(textBox1.Text);
            operacion = '/';
            textBox1.Clear();

        }

        private void button8_Click(object sender, EventArgs e)//CE
        {
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)//numero5
        {
            textBox1.Text += "5";
        }

        private void button14_Click(object sender, EventArgs e)//numero2
        {
            textBox1.Text += "2";
        }

        private void button12_Click(object sender, EventArgs e)//←
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//salida pantalla
        {

        }

        private void button5_Click(object sender, EventArgs e)//numero7
        {
            textBox1.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)//numero8
        {
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)//numero6
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)//numero9
        {
            textBox1.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)//numero4
        {
            textBox1.Text += "4";
        }

        private void button13_Click(object sender, EventArgs e)//numero1
        {
            textBox1.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)//numero3
        {
            textBox1.Text += "3";
        }

        private void button16_Click(object sender, EventArgs e)//IGUAL =
        {
            valor2 = double.Parse(textBox1.Text);
            double resultado = RealizarOperacion(valor1, valor2, operacion);
            textBox1.Text = resultado.ToString();
            valor1 = resultado;
            operacion = ' ';

        }

        private void button17_Click(object sender, EventArgs e)//numero0
        {
            textBox1.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)// PUNTO .
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }

        }


    }
    }