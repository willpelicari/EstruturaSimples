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
    /// Interaction logic for PilhaEstaticaTeoria.xaml
    /// </summary>
    public partial class PilhaEstaticaTeoria : Window
    {
        public PilhaEstaticaTeoria()
        {
            InitializeComponent();
        }

        private void pilhaEstaticaButton_Click(object sender, RoutedEventArgs e)
        {
            PilhaEstaticaWindow pilhaestatica = new PilhaEstaticaWindow();
            pilhaestatica.Show();
        }

        private void BuscarReferencia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.google.com.br/?q=pilha+estatica+estrutura+de+dados");
            }
            catch { }
        }
    }
}
