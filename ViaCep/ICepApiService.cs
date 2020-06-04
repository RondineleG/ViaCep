using Refit;
using System.Threading.Tasks;

namespace ViaCep
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> BuscaEndereco(string cep);
    }
}
