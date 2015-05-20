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
    public partial class PilhaEncadeadaWindow : Window
    {
        PilhaEncadeada Pilha = new PilhaEncadeada();
        public PilhaEncadeadaWindow()
        {
            InitializeComponent();
            Texto.Focus();
        }

        private void enterPrato(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                this.btnAdd_Click(sender, e);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            listBoxPilha.Items.Clear();
            Pilha.Add(Texto.Text);
            for (int i=Pilha.qtde-1;i>=0;i--)
                if (Pilha.getElemento(i)!="")
                {
                    listBoxPilha.Items.Add(Pilha.getElemento(i));
                }
            Texto.Clear();
            Texto.Focus();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            listBoxPilha.Items.Clear();
            Pilha.Delete();
            for (int i = Pilha.qtde-1; i >= 0; i--)
                if (Pilha.getElemento(i) != "")
                {
                    listBoxPilha.Items.Add(Pilha.getElemento(i));
                }
        }
    }
}
