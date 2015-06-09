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
using Microsoft.VisualBasic;
using System.Windows.Shapes;

namespace trabalhoUSC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class ListaEstaticaWindow : Window
    {

        int alterar = -1;
        bool pesquisa = false;
        ListaEstatica Lista = new ListaEstatica();
        public ListaEstaticaWindow()
        {
            InitializeComponent();
            Texto.Focus();
        }

        private void enterPessoa(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                if (alterar != -1)
                    this.btnAlterar_Click(sender, e);
                else if (pesquisa)
                    this.btnProcurar_Click(sender, e);
                else
                     this.btnAdd_Click(sender, e);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int pos = -1;
            string resposta= Interaction.InputBox("Qual posicao deseja adicionar?\n\n\n1=primeira\n2=segunda\n...", "Adicionar ingrediente na lista", "1", -1, -1);
            if (resposta.Length!=0)
                if (int.TryParse(resposta,out pos))
                    Lista.Add(Texto.Text, pos-1);
                else            
                    MessageBox.Show("Valor Inválido!");
            exibirIngredientes();
            Texto.Clear();
            Texto.Focus();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int pos = -1;
            string resposta = Interaction.InputBox("Qual posicao deseja remover?", "Remover ingrediente na lista", "1", -1, -1);
            if (resposta.Length != 0)
                if (int.TryParse(resposta, out pos))
                    Lista.Delete(pos - 1);
                else
                    MessageBox.Show("Valor Inválido!");
            exibirIngredientes();
        }

        private void exibirIngredientes()
        {
            listBoxLista.Items.Clear();
            EscrevaNome.Content = "Escreva um ingrediente:";
            btnAlterar.Visibility = System.Windows.Visibility.Visible;
            btnAdd.Visibility = System.Windows.Visibility.Visible;
            btnProcurar.Visibility = System.Windows.Visibility.Visible;
            btnDelete.Visibility = System.Windows.Visibility.Visible;
            pesquisa = false;
            alterar = -1;
            for (int i = 0; i < 20; i++)
                if (Lista.getElemento(i) != "")
                {
                    listBoxLista.Items.Add(Lista.getElemento(i));
                }
            btnAlterar.Content = "Alterar Ingrediente";
            btnProcurar.Content = "Procurar Ingrediente";
            Texto.Clear();
            Texto.Focus();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            string resposta;
            if (alterar!=-1)
            {
                Lista.Alterar(Texto.Text,alterar);
                exibirIngredientes();
            }
            else
            {
                if (Lista.getElemento(0) != "")
                {
                    resposta = Interaction.InputBox("Qual posicao deseja alterar?", "Alterar ingrediente da Lista", "1", -1, -1);
                    if (resposta.Length==0) return;
                    if (int.TryParse(resposta, out alterar))
                    {
                        EscrevaNome.Content = "Escreva um novo ingrediente para \"" + Lista.getElemento(--alterar) + "\": ";
                        Texto.Focus();
                        btnAdd.Visibility = System.Windows.Visibility.Hidden;
                        btnProcurar.Visibility = System.Windows.Visibility.Hidden;
                        btnDelete.Visibility = System.Windows.Visibility.Hidden;
                        btnAlterar.Content = "Confirmar";
                    }
                    else
                        MessageBox.Show("Valor Inválido!");
                }
                
                else
                {
                    MessageBox.Show("Sua Lista está vazia.", "Lista Vazia");
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
                if (Lista.getElemento(0) != "")
                {
                    EscrevaNome.Content = "Escreva o ingrediente que procura:";
                    Texto.Focus();
                    btnAlterar.Visibility = System.Windows.Visibility.Hidden;
                    btnAdd.Visibility = System.Windows.Visibility.Hidden;
                    btnDelete.Visibility = System.Windows.Visibility.Hidden;
                    btnProcurar.Content = "Confirmar";
                    pesquisa = true;
                }
                else
                {
                    MessageBox.Show("Sua lista está vazia.", "Lista Vazia");
                }
            }
        }
        private void Procurar(string Nome)
        {
            int posicaoEncontrada = Lista.getElemento(Nome);
            exibirIngredientes();
            if (posicaoEncontrada > -1)
            {
                listBoxLista.SelectedIndex = posicaoEncontrada;
                MessageBox.Show(Nome + " é o " + Convert.ToString(posicaoEncontrada + 1) + "º da lista. Corre que estamos com fome!", "Ingrediente Encontrado");
            }
            else
            {
                MessageBox.Show(Nome + " não foi encontrado na lista.\nVoce esqueceu dele?", "Ingrediente não Encontrado", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
