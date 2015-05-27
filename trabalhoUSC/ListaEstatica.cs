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
            for (int i = 0; i < Maximo; i++)
            {
                if (elementos[i].Equals(pesquisa))
                    return i;
            }
            return 0;
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
        public void Add(string valor)
        {
            if (qtde == Maximo)
            {
                MessageBox.Show("A lista ta cheia!", "Lista Cheia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            elementos[qtde] = valor;
            qtde++;
        }
        public void Delete()
        {
            if (qtde == 0)
            {
                MessageBox.Show("A lista está vazia, não?", "Pilha Vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show('"' + elementos[qtde-1] + "\" saiu da lista.", "Saindo da lista", MessageBoxButtons.OK);
            elementos[qtde - 1] = "";
            qtde--;
        }
    }
}
