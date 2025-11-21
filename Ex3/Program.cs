using System;

namespace Ex3
{
    public class Circulo
    {
        private double raio;

        public Circulo(double raio)
        {
            this.Raio = raio;
        }

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public double CalcularArea()
        {
            double area = Math.PI * Raio * Raio;
            return area;
        }

        public double CalularDiametro()
        {
            double diametro = 2 * Raio;
            return diametro;
        }

        public double CalularPerimetro()
        {
            double perimetro = 2 * Math.PI * Raio;
            return perimetro;
        }
    }
}

namespace Ex3
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            /*03. Crie uma classe "Circulo" com o campo "raio". Implemente um método construtor e a propriedade.
            Adicione os seguintes métodos:
            ● CalcularArea: método sem parâmetros, que deve calcular e retornar a área do círculo
            ● CalularDiametro: método sem parâmetros, que deve calcular e retornar o diâmetro do círculo.
            ● CalcularPerimetro: método sem parâmetros, que deve calcular e retornar o diâmetro do círculo.
            Implemente uma classe Teste (com método Main), crie 4 círculos e mostre a utilização de todos os métodos
            da classe Circulo.*/

            Circulo raio1 = new Circulo(4);
            Circulo raio2 = new Circulo(5);
            Circulo raio3 = new Circulo(6);
            Circulo raio4 = new Circulo(7);

            Console.WriteLine
            ($@"
            Cálculo da Área:

            Circulo 1 -> Raio : {raio1.Raio} = {raio1.CalcularArea()}
            Circulo 2 -> Raio : {raio2.Raio} = {raio2.CalcularArea()}
            Circulo 3 -> Raio : {raio3.Raio} = {raio3.CalcularArea()}
            Circulo 4 -> Raio : {raio4.Raio} = {raio4.CalcularArea()}
            ");

            Console.WriteLine
            ($@"
            Cálculo do Diâmetro:

            Circulo 1 -> {raio1.Raio} x 2 = {raio1.CalularDiametro()}
            Circulo 2 -> {raio2.Raio} x 2 = {raio2.CalularDiametro()}
            Circulo 3 -> {raio3.Raio} x 2 = {raio3.CalularDiametro()}
            Circulo 4 -> {raio4.Raio} x 2 = {raio4.CalularDiametro()}
            ");

            Console.WriteLine
            ($@"
            Cálculo do Perímetro:

            Circulo 1 -> Raio : {raio1.Raio} = {raio1.CalularPerimetro()}
            Circulo 2 -> Raio : {raio2.Raio} = {raio2.CalularPerimetro()}
            Circulo 3 -> Raio : {raio3.Raio} = {raio3.CalularPerimetro()}
            Circulo 4 -> Raio : {raio4.Raio} = {raio4.CalularPerimetro()}
            ");
        }
    }
}
