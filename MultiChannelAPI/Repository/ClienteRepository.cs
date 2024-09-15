using MultiChannelAPI.Model;
using MultiChannelAPI.Repository.Context;
using MultiChannelAPI.Repository.Interfaces;

namespace MultiChannelAPI.Repository;

internal class ClienteRepository : IClienteRepository
{
    private readonly ClienteContext _context;

    public ClienteRepository(ClienteContext context)
    {
        _context = context;
    }

    public async Task<Cliente> CriarClienteAsync(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
        return cliente;
    }

    public async Task<Cliente> ObterClientePorIdAsync(int id)
    {
        return await _context.Clientes.FindAsync(id);
    }
}