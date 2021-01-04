using System;
using System.Collections.Generic;//Listas utilizam um local diferente no sistema
using Listas_de_Objetos.classes;

namespace Listas_de_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtosLista = new List<Produto>(); //Lista instanciada de Produto
            //List<int> listInt = new List<int>(); - exemplo de sintaxe lista no formato inteiro, sem instanciamento

            //Adicionando item na lista através de um Método Construtor que solicita CODIGO(INT), NOME(STRING) E PRECO(FLOAT)
            produtosLista.Add(new Produto (1001, "Feijoada", 29.99f));
            produtosLista.Add(new Produto (1002, "Virado à Paulista", 21.99f));
            produtosLista.Add(new Produto (1003, "Panqueca Gratinada", 18.99f));
            produtosLista.Add(new Produto (1004, "Filé de Frango à Milanesa", 25.99f));
            produtosLista.Add(new Produto (1005, "Filé de Maminha à Milanesa", 27.99f));

            //Instanciar um produto novo à partir dos atributos da classe Produto
            Produto macarronada = new Produto();
            macarronada.Codigo  = 1006;
            macarronada.Nome    = "Macarronada";
            macarronada.Preco   = 19.99f;

            //Adiociona-se um item instanciado à lista da seguinte forma:
            produtosLista.Add(macarronada);

            //Exibir lista com ForEach
            foreach (Produto p in produtosLista)
            {
                Console.WriteLine($"Código: {p.Codigo} Nome: {p.Nome} - Preço: R${p.Preco}");
            }
            
            //Através da lógica do Array (posição inicial 0), podemos remover itens da lista
            produtosLista.RemoveAt(2);//Panqueca removida
            
            //!!! Pesquisar sobre Expressão Lambda !!!
            produtosLista.RemoveAll(x => x.Nome == "Virado à Paulista");

            //CHEGAGEM DE ALTERAÇÃO NA LISTA COM FOREACH
            Console.WriteLine("\nALTERAÇÕES APLICADAS (LISTA ATUALIZADA)\n");
            foreach (Produto p in produtosLista)
            {
                Console.WriteLine($"Código: {p.Codigo} Nome: {p.Nome} - Preço: R${p.Preco}");
            }


            //LISTA DE CARTÕES 

            List<Cartao> cartoes = new List<Cartao>();
            cartoes.Add(new Cartao ("Joaquina de França","5369 9080 3931 2812","MasterCard", "02/10/2028", 923));
            cartoes.Add(new Cartao ("João Miranda","4556 4376 4223 6396","Visa", "04/03/2022", 264));
            cartoes.Add(new Cartao ("Pedro Fonseca","379 703 854 735 976","American Express", "04/02/2022", 1401));
            cartoes.Add(new Cartao ("Astolfo Pacheco","6062 8266 5448 7651","HiperCard", "04/01/2023", 664));
            cartoes.Add(new Cartao ("Aparecido Costa","5367 5245 5523 9735","MasterCard", "04/06/2022", 903));
            cartoes.Add(new Cartao ("Solano Penha","4024 0071 1863 1505","Visa", "04/11/2021", 276));

            Console.WriteLine("Cartões cadastrados:\n");
            foreach (Cartao c in cartoes)
            {
                Console.WriteLine($"Nome Titular: {c.Nome}\nNúmero Cartão: {c.NumeroCartao}\nBandeira: {c.Bandeira}\nVenciemento: {c.Vencimento}\nCódigo: {c.Cvv}");
            }
        }
    }
}
