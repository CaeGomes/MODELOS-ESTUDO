using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_Series_Enum;

namespace DIO_Series_Classes
{
    public class Series : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; } //Informa se o registro está ou não excluído

        //Métodos

        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            ID = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;

            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de início: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;

            return retorno;
        }

        //Encapsulamento
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaID()
        {
            return this.ID;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}
