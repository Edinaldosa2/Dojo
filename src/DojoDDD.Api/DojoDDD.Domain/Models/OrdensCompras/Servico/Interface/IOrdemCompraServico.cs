using System.Threading.Tasks;

namespace DojoDDD.Api.DojoDDD.Domain
// Melhor prática seria trocar o namespace para ser o caminho correto.
{
    public interface IOrdemCompraServico
    {
        Task<string> ConsultarPorId(string id);
        Task<bool> AlterarStatudOrdemDeCompraParaEmAnalise(string ordemDeCompraId);
        Task<string> RegistrarOrdemCompra(string clienteId, int produtoId, int quantidadeCompra);
    }
}