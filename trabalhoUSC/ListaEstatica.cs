using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoUSC
{
    class ListaEstatica
    {
        private const int Maximo = 20;
        private string[] elementos = new string[Maximo];
        private int qtde;

        public ListaEstatica()
        {
            Clear();
        }
        public void Clear()
        {
            for (int i = 0; i < Maximo; i++)
                elementos[i]="";
            qtde = 0;
        }
        public string getElemento(int posicao)
        {
            return elementos[posicao];
        }
        public int getElemento(string pesquisa)
        {
            if (pesquisa.Length == 0)
                return -1;
            for (int i = 0; i < Maximo; i++)
            {
                if (string.Equals(elementos[i], pesquisa, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }
        public void setElemento(int posicao,string newText)
        {
            if (posicao > qtde - 1)
                MessageBox.Show("Posicao nao preenchida ainda");
            else
            {
                elementos[posicao] = newText;
            }                
        }
        public void Add(string valor, int posicao)
        {
            if (qtde == Maximo)
            {
                MessageBox.Show("A lista ta cheia!", "Lista Cheia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (posicao > qtde)
                MessageBox.Show("Posição Inválida!");
            else
            {
                if (posicao < qtde)
                    for (int i = qtde - 1; posicao <= i; i--)
                        elementos[i + 1] = elementos[i];
                elementos[posicao] = valor;
                qtde++;
            }
        }
        public void Delete(int posicao)
        {
            if (qtde == 0)
            {
                MessageBox.Show("A lista está vazia, não?", "Lista Vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (posicao > qtde)
                MessageBox.Show("Posição Inválida!");
            else
            {
                MessageBox.Show('"' + elementos[posicao] + "\" saiu da lista.", "Saindo da lista", MessageBoxButtons.OK);
                if (posicao < qtde)
                    for (int i = posicao; i < qtde - 1; i++)
                        elementos[i] = elementos[i + 1];
                elementos[qtde - 1] = "";
                qtde--;
            }
        }
        public void Alterar(string valor, int posicao)
        {
            if ((posicao > qtde) && (posicao < 0))
                MessageBox.Show("Posição inválida!");
            else
                elementos[posicao] = valor;
        }
    }
}
