using DIO.Curtas.Classes;

namespace DIO.Curtas.Classes
{
    public class Curtas : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Sinopse { get; set; }
        private string Direcao { get; set; }
        private string Pais { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Curtas(int id, Genero genero, string titulo, string sinopse, int ano, string direcao, string pais)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Sinopse = sinopse;
            this.Ano = ano;
            this.Direcao = direcao;
            this.Pais = pais;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Sinopse: " + this.Sinopse + Environment.NewLine;
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Dirigido por: " + this.Direcao + Environment.NewLine;
            retorno += "País de origem: " + this.Pais + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public int retornaAno()
        {
            return this.Ano;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }
}