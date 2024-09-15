namespace MultiChannelAPI.Services.Interfaces
{
    internal interface IEnderecoService
    {
        Task<string> ObterEnderecoPorCep(string cep);
    }
}
