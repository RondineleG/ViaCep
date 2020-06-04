using Refit;
using System;
using System.Threading.Tasks;

namespace ViaCep
{
    class Program
    {
        static async Task Main()
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
                
                Console.WriteLine("Informeo cep : ");

                var cepInformado = Console.ReadLine().ToString();

                var address = await cepClient.BuscaEndereco(cepInformado);

                Console.WriteLine($"Logradouro : {address.Logradouro}");
                Console.WriteLine($"Complemento : {address.Complemento}");
                Console.WriteLine($"Bairro : {address.Bairro}");
                Console.WriteLine($"UF : {address.Uf}");
                Console.WriteLine($"Cidade : {address.Localidade}");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro na consulta do cep : " + ex.Message);
            }
            
        }
    }
}
