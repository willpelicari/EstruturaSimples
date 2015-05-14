using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoUSC
{
    class FilaEncadeada
    {
        private const int Maximo = 20;
        private string[] elementos = new string[Maximo];
        private int qtde;
        public FilaEncadeada()
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
                if (elementos[i].Equals(pesquisa))
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
                return;
            elementos[qtde] = valor;
            qtde++;
        }
        public void Delete()
        {
            if (qtde == 0)
                return;
            for (int i=0;i<qtde;i++)
                elementos[i]=elementos[i+1];
            elementos[qtde] = "";
            qtde--;
        }
    }
}
