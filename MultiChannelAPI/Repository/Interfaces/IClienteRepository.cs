using MultiChannelAPI.Model;

namespace MultiChannelAPI.Repository.Interfaces
{
    internal interface IClienteRepository
    {
        Task<Cliente> CriarClienteAsync(Cliente cliente);
        Task<Cliente> ObterClientePorIdAsync(int id);
    }
}