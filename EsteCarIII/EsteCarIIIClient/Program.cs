using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using EstCarIIILibrary.Models;
using EsteCarIIILibrary;
using Newtonsoft.Json;

namespace EsteCarIIIClient
{
    class Program
    {
        static HttpClient cliente = new HttpClient();


        static async Task<Marca> GetMarcaAsync(string path)
        {
            Marca marca = null;
            HttpResponseMessage response = await cliente.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                marca = await response.Content.ReadAsAsync<Marca>();
            }

            return marca;
        }

        static async Task<List<Marca>> GetMarcasAsync(string path)
        {
            List<Marca> marcas = null;
            HttpResponseMessage response = await cliente.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                marcas = await response.Content.ReadAsAsync<List<Marca>>();
            }

            return marcas;
        }


        static async Task<HttpStatusCode> CreateMarcaAsync(Marca marca)
        {
            HttpResponseMessage response = await cliente.PostAsJsonAsync(
                "api/marcas", marca);
            response.EnsureSuccessStatusCode();
            // return URI of the created resource.
            return response.StatusCode;
        }

        static async Task<HttpStatusCode> UpdateMarcaAsync(Marca marca)
        {
            HttpResponseMessage response = await cliente.PutAsJsonAsync(
                $"api/marcas/{marca.MarcaId}", marca);
            response.EnsureSuccessStatusCode();
            return response.StatusCode;
        }

        static async Task<HttpStatusCode> DeleteMarcaAsync(int id)
        {
            HttpResponseMessage response = await cliente.DeleteAsync(
                $"api/marcas/{id}");
            return response.StatusCode;
        }

        public static void Main(string[] args)
        {
            //NECESSÁRIO MUDAR O VALOR DO PORTO PARA O QUE ESTÁ A SER USADO 
            cliente.BaseAddress = new Uri("http://localhost:65346/");
            cliente.DefaultRequestHeaders.Accept.Clear();
            cliente.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            Marca marca;
            List<Marca> marcas;
            int id;
            int opcao;
            do
            {
                Console.WriteLine();
                Console.WriteLine("[ 1 ] Consultar todas as marcas de carros");
                Console.WriteLine("[ 2 ] Consultar uma marca por id");
                Console.WriteLine("[ 3 ] Adicionar marca de carro");
                Console.WriteLine("[ 4 ] Alterar   marca de carro");
                Console.WriteLine("[ 5 ] Apagar    marca de carro");
                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite uma opção: ");
                opcao = Int32.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        marcas = GetMarcasAsync("api/Marcas").GetAwaiter().GetResult();
                        if (marcas != null)
                            Console.WriteLine("marcas: {0}", marcas.ListaMarcas());
                        break;
                    case 2:
                        Console.Write("Id=");
                        id = Int32.Parse(Console.ReadLine());
                        marca = GetMarcaAsync($"api/Marcas/{id}").GetAwaiter().GetResult();
                        if (marca != null)
                            Console.WriteLine("marca: {0}", marca.Designacao);
                        break;
                    case 3:
                        marca = new Marca();
                        Console.Write("Nome da marca=");
                        marca.Designacao = Console.ReadLine();
                        var result = CreateMarcaAsync(marca).GetAwaiter().GetResult();
                        Console.WriteLine("status: {0}", result);
                        break;
                    case 4:
                        Console.Write("Nome antigo: ");
                        String nomeAntigo = Console.ReadLine();
                        Console.Write("Nome novo  : ");
                        String nomeNovo = Console.ReadLine();

                        marcas = GetMarcasAsync($"api/Marcas").GetAwaiter().GetResult();
                        marca = marcas.FirstOrDefault(m => m.Designacao.Contains(nomeAntigo));
                        if (marca != null)
                        {
                            marca.Designacao = nomeNovo;
                            var status2 = UpdateMarcaAsync(marca).GetAwaiter().GetResult();
                            Console.WriteLine("status: {0}", status2);
                        }
                        else
                            Console.WriteLine("Marca {0} não existe", nomeAntigo);

                        break;
                    case 5:
                        Console.Write("apagar marca Id=");
                        id = Int32.Parse(Console.ReadLine());

                        var status = DeleteMarcaAsync(id).GetAwaiter().GetResult();
                        Console.WriteLine("status: {0}", status);
                        break;
                    default:
                        break;
                }

            } while (opcao != 0);
        }
    }
}
