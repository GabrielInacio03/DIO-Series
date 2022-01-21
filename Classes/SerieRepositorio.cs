using System;
using System.Collections.Generic;
using System.Linq;
using DIO.Series.Interface;

namespace DIO.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        List<Serie> series = new List<Serie>();
        public void Atualizar(int id, Serie entidade)
        {
            series[id] = entidade;
        }

        public void Excluir(int id)
        {
            series[id].excluir();
        }

        public void Insere(Serie entidade)
        {
            series.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return series;
        }

        public int ProximoId()
        {
            return series.Count();
        }

        public Serie RetornaPorId(int id)
        {
            return series[id];
        }
    }
}