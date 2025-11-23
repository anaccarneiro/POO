using System;

namespace Ex4
{
    public class Aluno
    {
        private string nome;
        private int matricula;
        private double[] notas = new double[10];

        public Aluno(string nome, int matricula, double[] notas)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Notas = notas;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        } 
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        } 
        public double [] Notas
        {
            get { return notas; }
            set { notas = value; }
        } 

        public double CalcularMedia()
        {
            double media = 0;
            int cont = 0;

            for ( int i = 0; i < notas.Length; i++)
            {
                    media += notas[i] / notas.Length;
            }

            return media;
        }
    }
}

namespace Ex4
{
    internal class Teste 
    {
        static void Main(string[] args)
        {
            /*04. Crie uma classe "Aluno" com os campos "nome", "matricula" e "notas" (array de double com tamanho
            10). Todos os campos devem ser privados. Adicione um método para calcular e retornar a média das notas
            do aluno. Implemente uma classe Teste (com método Main), crie dois alunos e imprima a média das notas dos alunos.*/

            Aluno aluno1 = new Aluno("Ana", 123456789, new double [] {8.0, 9.5, 7.0, 10.0, 8.5, 9.0, 6.5, 7.5, 8.0, 9.0});
            Aluno aluno2 = new Aluno("Enrico", 987654321, new double [] {7.5, 8.0, 7.0, 9.0, 7.0, 8.5, 7.5, 9.0, 8.5, 10.0});

            Console.WriteLine("Média de Ana: " + aluno1.CalcularMedia());
            Console.WriteLine("Média de Enrico: " + aluno2.CalcularMedia());
        }
    }
}
