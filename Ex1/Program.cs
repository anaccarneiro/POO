using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*01. Escreva um programa para cadastrar um cliente em uma loja. As informações necessárias são: “nome”,
            “endereço” e “telefone”. Crie uma classe Cliente com todos campos privados, dois métodos construtores
            diferentes e propriedades. No Main, crie três clientes, e utilize todas as propriedades.*/

            Cliente cliente1 = new Cliente("Ana", "Alianca", 98765432);
            Cliente cliente2 = new Cliente("João", "Anapurus", 12345678);
            Cliente cliente3 = new Cliente("Maria", "São Gabriel", 97520357);

            Console.WriteLine($@"
            Cliente 1: {cliente1.Nome}, {cliente1.Endereco}, {cliente1.Telefone}
            Cliente 2: {cliente2.Nome}, {cliente2.Endereco}, {cliente2.Telefone}
            Cliente 3: {cliente3.Nome}, {cliente3.Endereco}, {cliente3.Telefone}
            ");
            
        }
    }
}

