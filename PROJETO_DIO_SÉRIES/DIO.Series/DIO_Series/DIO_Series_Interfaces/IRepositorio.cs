using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Series_Interfaces
{
    public interface IRepositorio<T>
    {
        //Quem implementar essa interface, será OBRIGADO a implemntar os métodos
        //Métodos
        List<T> Lista();
        T RetornarPorID(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoID();
    }
}
