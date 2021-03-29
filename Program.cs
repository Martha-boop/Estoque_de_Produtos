using System;

namespace Estoque_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[6]  //usando array
            {
               " Mesa"," cadeira"," sofá", "cama"," geladeira", "fogão"
        };
            Console.WriteLine(produtos[0]);
            Console.ReadLine();
        }
    }
}
