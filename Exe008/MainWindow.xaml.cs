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

namespace Exe008
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btbSorteia_Click(object sender, RoutedEventArgs e)
        {
            int inicio, fim;
            int.TryParse(txtInicio1.Text, out inicio);
            int.TryParse(txtFim.Text, out fim);

            // sorteador
            Random gerador = new Random();
            int num = gerador.Next(inicio, fim + 1);
            lblMsg4.Content = $"Sorteando entre {inicio} e {fim}";
            await Task.Delay(2000);
            lblMsg4.Content = $"Sorteei o valor {num}";

        }
    }
}
