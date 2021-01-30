using ProjetoBase.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBase.App.Servicos
{
    public class ContaAPagar
    {

        private readonly IRepository _repository;

        public ContaAPagar(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<object> BuscarContasAPagar()
        {
            var result = _repository
                .Query<Domain.Entidades.ContaAPagar>()
                .Select(x => new
                {
                    x.Nome,
                    ValorOriginal = x.ValorOriginal.ToString("N"),
                    ValorCorrigido = x.ValorCorrigido.ToString("N"),
                    x.DiasDeAtraso,
                    DataPagamento = x.DataPagamento.ToString("dd/MM/yyyy")
                })
                .ToList();
            return result;
        }

        public Domain.Entidades.ContaAPagar BuscarPorId(int id)
        {
            var result = _repository.GetById<Domain.Entidades.ContaAPagar>(id);
            return result;
        }

        public void SalvarOuAtualizar(Domain.Entidades.ContaAPagar contaAPagar)
        {
            contaAPagar.ValorCorrigido = contaAPagar.ValorOriginal;
            contaAPagar.DiasDeAtraso = 0;

            if (contaAPagar.DataVencimento < contaAPagar.DataPagamento)
            {
                contaAPagar.DiasDeAtraso = (contaAPagar.DataPagamento - contaAPagar.DataVencimento).Days;

                decimal multa = 0;
                decimal juros = 0;
                if (contaAPagar.DiasDeAtraso <= 3)
                {
                    multa = 0.02m;
                    juros = 0.001m;
                }
                else if (contaAPagar.DiasDeAtraso <= 5)
                {
                    multa = 0.03m;
                    juros = 0.002m;
                }
                else
                {
                    multa = 0.05m;
                    juros = 0.003m;
                }

                contaAPagar.ValorCorrigido += decimal.Round(contaAPagar.ValorOriginal * multa, 2, System.MidpointRounding.AwayFromZero);

                for (int i = 0; i < contaAPagar.DiasDeAtraso; i++)
                {
                    contaAPagar.ValorCorrigido += decimal.Round(contaAPagar.ValorCorrigido * juros, 2, System.MidpointRounding.AwayFromZero);
                }

                contaAPagar.PercentualJuros = juros;
                contaAPagar.PercentualMulta = multa;
            }

            _repository.SaveOrUpdate(contaAPagar);
        }

        public void Excluir(int id)
        {
            _repository.Delete<Domain.Entidades.ContaAPagar>(id);
        }

    }
}
