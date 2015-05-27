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

        private void filaEncadeadaButton_Click(object sender, RoutedEventArgs e)
        {
            FilaEstaticaWindow filaencadeada = new FilaEstaticaWindow();
            filaencadeada.Show();
        }

        private void pilhaEncadeadaButton_Click(object sender, RoutedEventArgs e)
        {
            PilhaEstaticaWindow pilhaencadeada = new PilhaEstaticaWindow();
            pilhaencadeada.Show();
        }
    }
}
