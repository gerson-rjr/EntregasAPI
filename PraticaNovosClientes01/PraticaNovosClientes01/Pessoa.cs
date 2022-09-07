using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaNovosClientes01
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime DataCriacao { get; set; }


        public Pessoa(int id, string? nome, DateTime dataCriacao)
        {
            Id = id;
            Nome = nome;
            DataCriacao = dataCriacao;
        }

        public Pessoa()
        {

        }

        public override String ToString()
        {
            string? s = "";
            s += Nome;
            return s;
        }
    }
}
