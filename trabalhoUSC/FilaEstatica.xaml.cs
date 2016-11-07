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

    public partial class FilaEstaticaWindow : Window
    {
        bool alterar = false;
        bool pesquisa = false;

        FilaEstatica Fila = new FilaEstatica();
        public FilaEstaticaWindow()
        {
            InitializeComponent();
            Texto.Focus();
        }

        private void enterPessoa(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                if (pesquisa) Procurar(Texto.Text);
                else this.btnAdd_Click(sender, e);
            }
        }

        private void exibirPessoas()
        {
            listBoxFila.Items.Clear();
            EscrevaNome.Content = "Escreva um nome:";
            btnAlterar.Visibility = System.Windows.Visibility.Visible;
            btnAdd.Visibility = System.Windows.Visibility.Visible;
            btnProcurar.Visibility = System.Windows.Visibility.Visible;
            btnDelete.Visibility = System.Windows.Visibility.Visible;
            pesquisa = false;
            alterar = false;
            for (int i = 0; i < 20; i++)
                if (Fila.getElemento(i) != "")
                {
                    listBoxFila.Items.Add(Fila.getElemento(i));
                }
            btnAlterar.Content = "Alterar Pessoa";
            btnProcurar.Content = "Procurar Pessoa";
            Texto.Clear();
            Texto.Focus();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(!alterar)
                Fila.Add(Texto.Text);
            else
                Fila.Alterar(Texto.Text);
            exibirPessoas();
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

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (alterar)
            {
                Fila.Alterar(Texto.Text);
                exibirPessoas();
            }
            else
            {
                if (Fila.getElemento(0) != "")
                {
                    EscrevaNome.Content = "Escreva um novo nome para \"" + Fila.getElemento(0) + "\": ";
                    Texto.Focus();
                    btnAdd.Visibility = System.Windows.Visibility.Hidden;
                    btnProcurar.Visibility = System.Windows.Visibility.Hidden;
                    btnDelete.Visibility = System.Windows.Visibility.Hidden;
                    alterar = true;
                    btnAlterar.Content = "Confirmar";
                }
                else
                {
                    MessageBox.Show("Sua Fila está vazia.", "Fila Vazia");
                }
            }
        }

        private void btnProcurar_Click(object sender, RoutedEventArgs e)
        {
            if (pesquisa)
            {
                Procurar(Texto.Text);
            }
            else
            {
                if (Fila.getElemento(0) != "")
                {
                    EscrevaNome.Content = "Escreva o nome da pessoa que procura:";
                    Texto.Focus();
                    btnAlterar.Visibility = System.Windows.Visibility.Hidden;
                    btnAdd.Visibility = System.Windows.Visibility.Hidden;
                    btnDelete.Visibility = System.Windows.Visibility.Hidden;
                    btnProcurar.Content = "Confirmar";
                    pesquisa = true;
                }
                else
                {
                    MessageBox.Show("Sua Fila está vazia.", "Fila Vazia");
                }
            }
        }
        private void Procurar(string Nome)
        {
            int posicaoEncontrada = Fila.getElemento(Nome);
            exibirPessoas();
            if (posicaoEncontrada > -1)
            {
                listBoxFila.SelectedIndex = posicaoEncontrada;
                MessageBox.Show(Nome + " é o " + Convert.ToString(posicaoEncontrada+1) + "º da fila. Corre que o filme ja ja começa!", "Pessoa Encontrada");
            }
            else
            {
                MessageBox.Show(Nome + " não foi encontrado na fila. (Acho que ele/ela furou contigo...)", "Furo Encontrado", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

    }
}
