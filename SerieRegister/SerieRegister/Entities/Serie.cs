using SerieRegister.Entities.Base;
using SerieRegister.Enum;

namespace SerieRegister.Entities
{
    public class Serie : EntityBase
    {
        // Atributos
        private Gender Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        // Métodos
        public Serie(int id, Gender genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            return
                $"Gênero: {Genero} \n" +
                $"Titulo: {Titulo} \n" +
                $"Descrição: {Descricao} \n" +
                $"Ano de Início: {Ano} \n" +
                $"Excluido: {Excluido}";

        }

        public string RetornaTitulo()
        {
            return Titulo;
        }

        public int RetornaId()
        {
            return Id;
        }
        public bool RetornaExcluido()
        {
            return Excluido;
        }
        public void Excluir()
        {
            Excluido = true;
        }
    }
}
