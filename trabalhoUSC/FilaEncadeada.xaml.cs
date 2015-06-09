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
        bool alterar = false;
        bool pesquisa = false;

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
            string[] elementos = Fila.Mostrar();
            for (int i = 0; i < Fila.Contador(); i++)
               listBoxFila.Items.Add(elementos[i]);
            AtualizaRoda();
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
            string[] elementos = Fila.Mostrar();
            int Tag = int.Parse(BatataQuente.Tag.ToString());
            if(Tag == elementos.Length-1) BatataQuente.Tag = Tag-1; 
            Fila.Delete();
            exibirPessoas();
        }

        /*private void btnAlterar_Click(object sender, RoutedEventArgs e)
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
        }*/

        /*private void btnProcurar_Click(object sender, RoutedEventArgs e)
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
        }*/
        /*private void Procurar(string Nome)
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
            
        }*/
        public void Procurar(string Texto)
        {
            //TODO
        }

        public void AtualizaRoda()
        {
            string[] elementos = Fila.Mostrar();
            int Tag = int.Parse(BatataQuente.Tag.ToString());

            if (elementos.Length > 0) //se tiver elementos...
            {
                PrimeiroRodada.Content = elementos[0];
                UltimoRodada.Content = elementos[elementos.Length - 1];
                if (elementos.Length == 1) //se tiver apenas um elemento...
                {
                    Atual.Text = elementos[0];
                    Proximo.Text = elementos[0];
                    Anterior.Text = elementos[0];
                }
                else if (Tag == elementos.Length - 1) //se for o ultimo...
                {
                    //Ultimo elemento
                    Anterior.Text = elementos[Tag - 1];
                    Atual.Text = elementos[Tag];
                    Proximo.Text = elementos[0];
                }
                else if (Tag == 0 || Tag == -1)
                {
                    Anterior.Text = elementos[elementos.Length - 1];
                    Atual.Text = elementos[0];
                    if (elementos.Length == 2) Proximo.Text = elementos[elementos.Length - 1]; //se tiver 2
                    if (Tag == -1)
                    {
                        Proximo.Text = elementos[1];
                        BatataQuente.Tag = 0;
                    }
                }
                else //se for o resto
                {
                    Anterior.Text = elementos[Tag - 1];
                    Atual.Text = elementos[Tag];
                    Proximo.Text = elementos[Tag + 1];
                }

            }
            else
            {
                PrimeiroRodada.Content = "";
                UltimoRodada.Content = "";
                Atual.Text = "";
                Proximo.Text = "";
                Anterior.Text = "";
                BatataQuente.Tag = 0;
            }
        }

        private void BatataQuente_Click(object sender, RoutedEventArgs e)
        {
            string[] elementos = Fila.Mostrar();
            int Tag = int.Parse(BatataQuente.Tag.ToString());
            if(Tag == elementos.Length-1){
                BatataQuente.Tag = -1;
            }else{
                BatataQuente.Tag = Tag + 1;
            }
            AtualizaRoda();
            /*if(Tag < elementos.Length && Tag != -1){
                //Segundo clique ou mais. chame ate chegar ao inicio
                Atual.Text = elementos[Tag];
                if (Tag == 0) {
                    Anterior.Text = elementos[elementos.Length - 1];
                    Proximo.Text = elementos[Tag + 1];
                }
                else
                {
                    Anterior.Text = elementos[Tag - 1];
                    if (Tag == elementos.Length-1) Proximo.Text = elementos[0];
                    else Proximo.Text = elementos[Tag + 1];
                }
                BatataQuente.Tag = Tag + 1;
            }else{
                //Primeiro clique ou deu a volta, chame primeiro elemento
                if (Tag == -1)
                {
                    Anterior.Text = elementos[0];
                    Atual.Text = elementos[1];
                    Proximo.Text = elementos[2];
                    BatataQuente.Tag = 2;
                }
                else
                {
                    Anterior.Text = elementos[Tag - 1];
                    Atual.Text = elementos[0];
                    Proximo.Text = elementos[1];
                    BatataQuente.Tag = 1;
                }
                
            }*/
        }
    }
}
