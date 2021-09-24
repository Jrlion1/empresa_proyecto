using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioClientes
    {
        IEnumerable<Cliente> GetAllCliente();
         Cliente addCliente(Cliente cliente);
         Cliente updateCliente(Cliente cliente);
         void deleteCliente(Cliente cliente);
         Cliente getCliente(Cliente cliente);
    }
}