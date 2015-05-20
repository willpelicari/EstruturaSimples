﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            {
                MessageBox.Show("A fila ta cheia! Vamos dizer que bateu na porta, ok?", "Fila Cheia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            elementos[qtde] = valor;
            qtde++;
        }
        public void Delete()
        {
            if (qtde == 0)
            {
                MessageBox.Show("A fila parece vazia, não?", "Fila Vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i=0;i<qtde;i++)
                elementos[i]=elementos[i+1];
            MessageBox.Show('"' + elementos[qtde] + "\" entrou no cinema.", "Entrando no Cinema", MessageBoxButtons.OK);
            elementos[qtde] = "";
            qtde--;
        }
    }
}
