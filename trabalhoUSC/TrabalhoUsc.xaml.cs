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
using System.Windows.Shapes;

namespace trabalhoUSC
{
    /// <summary>
    /// Interaction logic for TrabalhoUsc.xaml
    /// </summary>
    public partial class TrabalhoUsc : Window
    {
        public TrabalhoUsc()
        {
            InitializeComponent();
        }

        private void filaEstaticaButton_Click(object sender, RoutedEventArgs e)
        {
            FilaEstaticaTeoria filaestatica = new FilaEstaticaTeoria();
            filaestatica.Show();
        }

        private void pilhaEstaticaButton_Click(object sender, RoutedEventArgs e)
        {
            PilhaEstaticaTeoria pilhaestatica = new PilhaEstaticaTeoria();
            pilhaestatica.Show();
        }

        private void SobreButton_Click(object sender, RoutedEventArgs e)
        {
            SobreEstruturaSimples sobre = new SobreEstruturaSimples();
            sobre.Show();
        }

        private void listaEstaticaButton_Click(object sender, RoutedEventArgs e)
        {
            ListaEstaticaTeoria listaestatica = new ListaEstaticaTeoria();
            listaestatica.Show();
        }

        private void filaEncadeadaButton_Click(object sender, RoutedEventArgs e)
        {
            FilaEncadeadaTeoria filaencadeada = new FilaEncadeadaTeoria();
            filaencadeada.Show();
        }
    }
}
