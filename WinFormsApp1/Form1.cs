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
         
        }

        private void button10_Click(object sender, EventArgs e)//numero5
        {
           
        }

        private void button14_Click(object sender, EventArgs e)//numero2
        {
           
        }

        private void button12_Click(object sender, EventArgs e)//←
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//salida pantalla
        {

        }

        private void button5_Click(object sender, EventArgs e)//numero7
        {

        }

        private void button6_Click(object sender, EventArgs e)//numero8
        {

        }

        private void button11_Click(object sender, EventArgs e)//numero6
        {
    
        }

        private void button7_Click(object sender, EventArgs e)//numero9
        {

        }

        private void button9_Click(object sender, EventArgs e)//numero4
        {
  
        }

        private void button13_Click(object sender, EventArgs e)//numero1
        {
      
        }

        private void button15_Click(object sender, EventArgs e)//numero3
        {

        }

        private void button16_Click(object sender, EventArgs e)//IGUAL =
        {
           
        }

        private void button17_Click(object sender, EventArgs e)//numero0
        {
      
        }

        private void button18_Click(object sender, EventArgs e)// PUNTO .
        {
        }

       
        }
    }