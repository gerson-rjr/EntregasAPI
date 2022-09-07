using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaNovosClientes01
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {

        public PessoaMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.DataCriacao).IsRequired().HasColumnType("datetime");
        }
    }
}
