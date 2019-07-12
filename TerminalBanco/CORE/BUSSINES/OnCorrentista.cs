using CORE.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.BUSSINES
{
    public class OnCorrentista :IEntidade<Correntista>
    {
        public void Novo(Correntista registro)
        {
            try
            {
                using (var db = new terminalEntities())
                {
                    db.Correntistas.Add(registro);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Salvar(Correntista registro)
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

        public void Excluir(Correntista registro)
        {
            try
            {
                using(var db = new terminalEntities())
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

        public List<Correntista> Lista()
        {
            try
            {
                using(var db = new terminalEntities())
                {
                    return db.Correntistas.Include("Conta").OrderBy(p => p.CPF).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
