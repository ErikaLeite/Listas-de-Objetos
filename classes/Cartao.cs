using System;

namespace Listas_de_Objetos.classes
{
    public class Cartao
    {
        public string Nome { get; set; }
        public string NumeroCartao { get; set; }
        public string Bandeira { get; set; }
        
        public string Vencimento { get; set; }
        public int Cvv { get; set; }
        
        public Cartao(){

        }
        public Cartao(string _nome, string _numeroCartao, string _bandeira, string _vencimento, int _cvv)
        {
            this.Nome         = _nome;
            this.NumeroCartao = _numeroCartao;
            this.Bandeira     = _bandeira;
            this.Vencimento   = _vencimento;
            this.Cvv          = _cvv;

        }
    }
}