using CORE.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.BUSSINES
{
    public class OnLancamento
    {

        public void Saque(Conta registro)
        {
            try
            {
               

            }catch (Exception)
            {

            }
        }


        public void Transferencia(Conta registro)
        {

        }




        public List<VIEW.ViewLancamento> ListaExtrato()
        {
            try
            {
                using(var db = new terminalEntities())
                {
                    var dados = from p in db.Lancamentoes.Include("Conta")
                                orderby p.Data
                                select new VIEW.ViewLancamento
                                {
                                    Id = p.Id,
                                    Data = p.Data,
                                    ContaId = p.ContaId,
                                    Operacao = p.Operacao,
                                    Historico = p.Historico,
                                    Valor = p.Valor
                                };
                    return dados.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
