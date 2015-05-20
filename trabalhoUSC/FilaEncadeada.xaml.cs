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

namespace trabalhoUSC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class FilaEncadeadaWindow : Window
    {
        FilaEncadeada Fila = new FilaEncadeada();
        public FilaEncadeadaWindow()
        {
            InitializeComponent();
            Texto.Focus();
        }

        private void enterPessoa(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                this.btnAdd_Click(sender, e);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            listBoxFila.Items.Clear();
            Fila.Add(Texto.Text);
            for (int i=0;i<20;i++)
                if (Fila.getElemento(i)!="")
                {
                    listBoxFila.Items.Add(Fila.getElemento(i));
                }
            Texto.Clear();
            Texto.Focus();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            listBoxFila.Items.Clear();
            Fila.Delete();
            for (int i = 0; i < 20; i++)
                if (Fila.getElemento(i) != "")
                {
                    listBoxFila.Items.Add(Fila.getElemento(i));
                }
        }
    }
}
