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
    /// Interaction logic for FilaEncadeadaTeoria.xaml
    /// </summary>
    public partial class FilaEncadeadaTeoria : Window
    {
        public FilaEncadeadaTeoria()
        {
            InitializeComponent();
        }

        private void pilhaEstaticaExemplo_Click(object sender, RoutedEventArgs e)
        {
            FilaEncadeadaWindow filaencadeada = new FilaEncadeadaWindow();
            filaencadeada.Show();
        }
    }
}
