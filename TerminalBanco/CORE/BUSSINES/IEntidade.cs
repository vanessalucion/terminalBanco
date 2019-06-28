using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.BUSSINES
{
    interface IEntidade<T>
    {
        void Novo(T registro);
        void Salvar(T registro);
        void Excluir(T registro);
        List<T> Lista();
    }
}
