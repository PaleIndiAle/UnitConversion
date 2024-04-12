namespace UnitConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int choice = Convert.ToInt32(modeInput.Text);
            double value = Convert.ToDouble(valueInput.Text);
            double multiplier;
            double answer;

            switch (choice)
            {
                case 1:
                    multiplier = 2.54;
                    answer = calculate(value, multiplier);
                    conversionOutput.Text = $"{value} inches = {answer} centimetres";
                    break;
                case 2:
                    multiplier = 30.48;
                    answer = calculate(value, multiplier);
                    conversionOutput.Text = $"{value} feet = {answer} centimetres";
                    break;
                case 3:
                    multiplier = 0.91;
                    answer = calculate(value, multiplier);
                    conversionOutput.Text = $"{value} yard = {answer} metres";
                    break;
                case 4:
                    multiplier = 1.6;
                    answer = calculate(value, multiplier);
                    conversionOutput.Text = $"{value} miles = {answer} kilometres";
                    break;
            }
        }

        private double calculate(double value, double multiplier)
        {
            double sum = value * multiplier;
            return sum;
        }
    }
}
