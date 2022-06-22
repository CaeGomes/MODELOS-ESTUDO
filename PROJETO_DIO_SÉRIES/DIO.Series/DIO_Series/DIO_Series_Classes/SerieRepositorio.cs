using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_Series_Interfaces;

namespace DIO_Series_Classes
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualiza(int id, Series objEntidade)
        {
            listaSerie[id] = objEntidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Series objEntidade)
        {
            listaSerie.Add(objEntidade);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoID()
        {
            return listaSerie.Count;
        }

        public Series RetornarPorID(int id)
        {
            return listaSerie[id];
        }
    }
}
