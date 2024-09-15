using MultiChannelAPI.Services.Interfaces;
using Newtonsoft.Json;

namespace MultiChannelAPI.Services;

internal class ViaCepService : IEnderecoService
{
    private readonly HttpClient _httpClient;

    public ViaCepService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> ObterEnderecoPorCep(string cep)
    {
        var response = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
        if (response.IsSuccessStatusCode)
        {
            var conteudo = await response.Content.ReadAsStringAsync();

            dynamic endereco = JsonConvert.DeserializeObject(conteudo);

            return $"{endereco?.logradouro}, {endereco?.bairro}, {endereco?.localidade}, {endereco?.uf}";
        }
        return string.Empty;
    }
}