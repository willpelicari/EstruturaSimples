using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoUSC
{
    class PilhaEstatica
    {
        private const int Maximo = 20;
        private string[] elementos = new string[Maximo];
        public int qtde;
        public PilhaEstatica()
        {
            Clear();
        }
        public void Clear()
        {
            for (int i = 0; i < Maximo; i++)
                elementos[i] = "";
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
                if (string.Equals(elementos[i], pesquisa, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return 0;
        }
        public void setElemento(string newText)
        {
            elementos[qtde] = newText;
        }
        public void Add(string valor)
        {
            if (qtde == Maximo)
            {
                MessageBox.Show("A pilha ta cheia! Onde estão esses ajudantes?", "Pilha Cheia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            elementos[qtde] = valor;
            qtde++;
        }
        public void Delete()
        {
            if (qtde == 0)
            {
                MessageBox.Show("A pilha está vazia, não?", "Pilha Vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show('"' + elementos[qtde-1] + "\" foi lavado.", "Lavando Louça", MessageBoxButtons.OK);
            elementos[qtde - 1] = "";
            qtde--;
        }
    }
}
