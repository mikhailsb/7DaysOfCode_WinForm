using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAsService.Models
{
    class ImageGatinho
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("width")]
        public int width { get; set; }

        [JsonProperty("height")]
        public int height { get; set; }
        public static async Task<ImageGatinho> BuscarImagemGato(string Id)
        {
            try
            {
                //ImageGatinho gatos = JsonConvert.DeserializeObject<ImageGatinho>(Json);
                //return gatos;

                var imgGato = await "https://api.thecatapi.com/v1/"
                    .AppendPathSegment("images/search")
                    .SetQueryParam("breed_ids", Id)
                    .GetJsonAsync<List<ImageGatinho>>();

                return imgGato.FirstOrDefault();
            }
            catch (FlurlHttpTimeoutException ex)
            {
                throw new Exception($"Tempo excedido na consulta a API. \nMensagem de erro retornada: {ex.Message}");
            }
            catch (FlurlHttpException ex)
            {
                throw new Exception($"Erro na consulta de imagem na API. \nMensagem de erro retornada: {ex.Message}");
            }
            
        }
    }
}
