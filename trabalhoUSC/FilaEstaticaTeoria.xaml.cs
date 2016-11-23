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
    /// Interaction logic for FilaEstaticaTeoria.xaml
    /// </summary>
    public partial class FilaEstaticaTeoria : Window
    {
        public FilaEstaticaTeoria()
        {
            InitializeComponent();
        }

        private void filaEstaticaExemplo_Click(object sender, RoutedEventArgs e)
        {
            FilaEstaticaWindow filaestatica = new FilaEstaticaWindow();
            filaestatica.Show();
        }

        private void BuscarReferencia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.google.com.br/?q=fila+estatica+estrutura+de+dados");
            }
            catch { }
        }

    }
}
