using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.Domain.Models
{
    public class Conta
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? Valor { get; set; }

        public  Categoria? Categoria { get; set; }

    }
}