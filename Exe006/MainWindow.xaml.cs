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

namespace Exe006
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            // torna o painel resultado visível
            panResultado.Visibility = Visibility.Visible;
            
            // variável recebe o ano atual
            int anoAtual = DateTime.Now.Year;
            
            // lblMsg1 recebe uma string interpolada
            lblMsg1.Content = $"Estamos no ano de {anoAtual}";
            
            // variável ano do nascimento recebe zero
            int anoNascimento = 0;
            
            // use o TryParse para receber o texto atual e transforma-lo em inteiro
            int.TryParse(txtNascimento.Text, out anoNascimento);
            
            //variável idade recebe o cálculo
            int idade = anoAtual - anoNascimento;
            
            // imprime o resultado
            lblMsg2.Content = $"Quem nasceu em {anoNascimento} vai ter {idade} anos.\n";
        }
    }
}
