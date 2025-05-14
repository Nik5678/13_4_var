namespace _13_4_вариант
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double CalculateTerm(int i, double x)
        {
            if (x == 0)
                throw new DivideByZeroException("x не может быть нулём.");
            return i / Math.Pow(x, i);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(textBoxX.Text, out double x))
                {
                    MessageBox.Show("Введите корректное значение x.", "Ошибка");
                    return;
                }

                if (x == 0)
                {
                    MessageBox.Show("x не может быть нулём.", "Ошибка");
                    return;
                }
                double product = 1.0;
                for (int i = 1; i <= 10; i++)
                {
                    double term = CalculateTerm(i, x);
                    product *= term;
                }

                labelResult.Text = $"Результат: {product:E6}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
    }
}
