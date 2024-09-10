namespace Calculator
{
    public partial class Form1 : Form
    {
        public static CalculatorClass cal;

        double num1, num2;
        public Form1()
        {
            InitializeComponent();

            cal = new CalculatorClass();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);


            if (comboBox1.Text.Equals("+"))
            {
               
                answer.Text = cal.GetSum(num1,num2).ToString();
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);


            }
            else if (comboBox1.Text == "-")
            {

                answer.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }
            else if (comboBox1.Text == "*")
            {

                answer.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }
            else if (comboBox1.Text == "/")
            {

                answer.Text = cal.GetDivide(num1, num2).ToString();
                cal.CalculateEvent += new Formula<double>(cal.GetDivide);
                cal.CalculateEvent -= new Formula<double>(cal.GetDivide);
            }
        }
    }
}
