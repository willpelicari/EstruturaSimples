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
    /// Interaction logic for ListaEstaticaTeoria.xaml
    /// </summary>
    public partial class ListaEstaticaTeoria : Window
    {
        public ListaEstaticaTeoria()
        {
            InitializeComponent();
        }

        private void ListaEstaticaExemplo_Click(object sender, RoutedEventArgs e)
        {
            ListaEstaticaWindow listaestatica = new ListaEstaticaWindow();
            listaestatica.Show();
        }
    }
}
