using System;
using DIO.Series.Enum;

namespace DIO.Series.Classes
{
    public class Serie : EntidadeBase
    {
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private Genero Genero { get; set; }

        public Serie(int id, string Titulo, string Descricao, int Ano, Genero Genero)
        {
            this.Id = Id;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Genero = Genero;
        }
        public override string ToString()
        {
            //return base.ToString();
            string retorno = "";
            retorno += "Titulo: "+ this.Titulo + Environment.NewLine;
            retorno += "Descrição: "+ this.Descricao + Environment.NewLine;
            retorno += "Ano: "+ this.Ano + Environment.NewLine;
            retorno += "Gênero: "+ this.Genero + Environment.NewLine;

            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaInt()
        {
            return this.Id;
        }
    }
}