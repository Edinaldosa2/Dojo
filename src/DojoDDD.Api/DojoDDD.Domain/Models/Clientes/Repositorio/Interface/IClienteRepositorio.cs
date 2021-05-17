using DojoDDD.Api.DojoDDD.Domain.Models.Clientes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Api.DojoDDD.Domain.Models.Clientes
// Melhor prática seria trocar o namespace para ser o caminho correto.
{
    public interface IClienteRepositorio
    {
        Task<Cliente> ConsultarPorId(string id);
        Task<IEnumerable<Cliente>> ConsultarTodosCliente();
    }
}