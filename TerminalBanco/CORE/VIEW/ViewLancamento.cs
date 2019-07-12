using CORE.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.VIEW
{
    public class ViewLancamento
    {

        public int Id { get; set; }        
        public Nullable<DateTime> Data { get; set; }
        public Nullable<int> ContaId { get; set; }
        public string Operacao { get; set; }
        public string Historico { get; set; }
        public Nullable<decimal> Valor { get; set; }

        public virtual Conta conta
        {
            get; set;
        }
        
}
}
