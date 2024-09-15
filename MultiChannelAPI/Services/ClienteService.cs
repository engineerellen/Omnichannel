using MultiChannelAPI.Model;
using MultiChannelAPI.Repository.Interfaces;
using MultiChannelAPI.Services.Interfaces;

namespace MultiChannelAPI.Services;

internal class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;
    private readonly IEnderecoService _enderecoService;

    public ClienteService(IClienteRepository clienteRepository, IEnderecoService enderecoService)
    {
        _clienteRepository = clienteRepository;
        _enderecoService = enderecoService;
    }

    public async Task<Cliente> CriarClienteAsync(Cliente cliente)
    {
        var endereco = await _enderecoService.ObterEnderecoPorCep(cliente.Cep);
        if (string.IsNullOrEmpty(endereco))
            throw new ArgumentException("CEP inválido.");

        cliente.Endereco = endereco;
        return await _clienteRepository.CriarClienteAsync(cliente);
    }
}