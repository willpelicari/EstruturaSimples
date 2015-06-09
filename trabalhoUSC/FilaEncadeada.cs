using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoUSC
{

    public class Pessoa
    {
        public string nome;
        public Pessoa proximo, anterior;
        public Pessoa(string Nome)
        {
            this.nome = Nome;
            this.proximo = this;
            this.anterior = this;
        }
        public Pessoa(string Nome, Pessoa Anterior, Pessoa Inicio)
        {
            this.nome = Nome;
            //Anterior
            this.anterior = Anterior;
            Anterior.proximo = this;
            //Proximo
            this.proximo = Inicio;
        }
    }

    class FilaEncadeada
    {

        public Pessoa Inicio, Fim, aux;

        public FilaEncadeada()
        {
            Inicio = null;
            Fim = null;
        }

        public void Add(string Nome)
        {
            if (this.Inicio == null) //Se inicio for vazio, lista vazia.
            {
                this.Inicio = new Pessoa(Nome);
                this.Fim = this.Inicio;
            }
            else
            {
                aux = new Pessoa(Nome, Fim, Inicio);
                Fim = aux;
                Inicio.anterior = Fim;
            }
        }

        public int Contador()
        {
            if (Inicio == null)
            {
                return 0;
            }
            else if (Inicio == Inicio.anterior)
            {
                return 1;
            }
            else
            {
                aux = Inicio;
                int i = 0;
                do
                {
                    i++;
                    aux = aux.proximo;
                } while (aux != Inicio);
                return i;
            }
        }

        public void Delete()
        {
            if (this.Inicio == null)
            {
                MessageBox.Show("Fila Vazia!");
            }
            else if (this.Inicio == this.Fim) //Zerou a lista
            {
                this.Inicio = null;
                this.Fim = this.Inicio;
            }
            else
            {
                aux = this.Inicio.proximo;
                aux.anterior = Fim;
                Inicio = aux;
                Fim.proximo = Inicio;
            }
        }

        public string[] Mostrar()
        {
            int total = Contador();
            string[] retornar = new string[total];
            aux = Inicio;
            for (int i = 0; i < total; i++)
            {
                retornar[i] = aux.nome;
                aux = aux.proximo;
            }
            return retornar;
        }

        public void Alterar(string Texto){
            //TODO
        }

    }
}