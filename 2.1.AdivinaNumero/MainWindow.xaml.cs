using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Random seed = new Random();
        private int numeroSecreto;

        public MainWindow()
        {
            InitializeComponent();
            
            numeroSecreto = seed.Next(1, 101);
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numeroSecreto = seed.Next(1, 101);
            AssertTextBlock.Text = "Empezamos otra vez, tengo un nuevo numero";
        }

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(InputTextBox.Text) > numeroSecreto)
            {
                AssertTextBlock.Text = "Menor";
            }
            else if(int.Parse(InputTextBox.Text) < numeroSecreto)
            {
                AssertTextBlock.Text = "Mayor";

            }
            else
            {
                AssertTextBlock.Text = "Correcto";
            }
        }
    }
}
