using System.Windows;
using System.Windows.Controls;

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            calcularButton.IsEnabled = false;
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int operando1 = int.Parse(operando1TextBox.Text),
                    operando2 = int.Parse(operando2TextBox.Text);
                switch (operadorTextBox.Text)
                {
                    case "+":
                        resultadoTextBox.Text = (operando1 + operando2).ToString();
                        break;
                    case "-":
                        resultadoTextBox.Text = (operando1 - operando2).ToString();
                        break;
                    case "*":
                        resultadoTextBox.Text = (operando1 * operando2).ToString();
                        break;
                    case "/":
                        resultadoTextBox.Text = (operando1 / operando2).ToString();
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Se ha producido un error. Revise los operandos.");
            }
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Text = "";
            operando2TextBox.Text = "";
            operadorTextBox.Text = "";
            resultadoTextBox.Text = "";
        }

        private void operadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (operadorTextBox.Text == "+" || operadorTextBox.Text == "-" || operadorTextBox.Text == "*" || operadorTextBox.Text == "/")
                calcularButton.IsEnabled = true;
            else
                calcularButton.IsEnabled = false;
        }
    }
}