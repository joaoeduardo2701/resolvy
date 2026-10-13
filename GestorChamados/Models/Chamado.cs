using GestorChamados.Enums;
using GestorChamados.Models;

namespace GestorChamados.Entities
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public Status Status { get; set; } = Status.Aberto;
        public Prioridade Prioridade { get; set; } = Prioridade.Baixa;
        public Modalidade Modalidade { get; set; } 
        public DateTime DataDeAbertura { get; set; } = DateTime.UtcNow;
        public DateTime DataDeFechamento { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
    }
}
