using System;

namespace Ex1
{
    public class Cliente
    {
        private string nome;
        private string endereco;
        private int telefone;

        public Cliente(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public Cliente(string nome, string endereco, int telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

    }
}
