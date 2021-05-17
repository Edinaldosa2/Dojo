using System.Threading.Tasks;

namespace DojoDDD.Api.DojoDDD.Domain
// Melhor prática seria trocar o namespace para ser o caminho correto.
{
    public interface IOrdemCompraRepositorio
    {
        Task<string> RegistrarOrdemCompra(OrdemCompra ordemCompra);
        Task<bool> AlterarOrdemCompra(string ordemId, OrdemCompraStatus novoOrdemCompraStatus);
        Task<string> ConsultarPorId(string id);
    }
}