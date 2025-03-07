using System;

namespace GestorFinanceiro.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public decimal valor { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public string Categoria { get; set; } = "Outros";
        public string Tipo { get; set; } = "Saída";

        public override string ToString()
        {
            return $"{Id}: {Descricao} | {Tipo} | R$ {Valor} | {Categoria} | {Data:d}";
        }
    }
}
