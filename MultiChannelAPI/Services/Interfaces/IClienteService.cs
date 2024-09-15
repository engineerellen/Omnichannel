using MultiChannelAPI.Model;

namespace MultiChannelAPI.Services.Interfaces
{
    internal interface IClienteService
    {
        Task<Cliente> CriarClienteAsync(Cliente cliente);
    }
}