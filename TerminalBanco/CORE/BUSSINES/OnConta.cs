using CORE.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.BUSSINES
{
    public class OnConta : IEntidade<Conta>
    {
        public void Excluir(Conta registro)
        {
            try
            {
                using (var db = new terminalEntities())
                {
                    db.Entry(registro).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Conta> Lista()
        {
            try
            {
                using (var db = new terminalEntities())
                {
                    return db.Contas.Include("Correntista").ToList();
                 
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Novo(Conta registro)
        {
            try
            {
                using (var db = new terminalEntities())
                {
                    db.Contas.Add(registro);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Salvar(Conta registro)
        {
            try
            {
                using (var db = new terminalEntities())
                {
                    db.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
