using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoBase.Domain.Entidades
{
    public class ContaAPagar : EntidadeBase
    {

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayName("Valor Original")]
        public decimal ValorOriginal { get; set; }

        [DisplayName("Valor Corrigido")]
        public decimal ValorCorrigido { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayName("Data Vencimento")]
        public DateTime DataVencimento { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayName("Data Pagamento")]
        public DateTime DataPagamento { get; set; }

        [DisplayName("Quantidade de Dias de Atraso")]
        public int DiasDeAtraso { get; set; }

        [DisplayName("Percentual de Juros")]
        public decimal PercentualJuros { get; set; }

        [DisplayName("Percentual de Multa")]
        public decimal PercentualMulta { get; set; }

    }
}
