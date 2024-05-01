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
    public class Favoritar
    {
        [JsonProperty("image_id")]
        public string image_id { get; set; }

        [JsonProperty("sub_id")]
        public string sub_id { get; set; }

        public async Task<string> AdicionarFavoritos(Favoritar fav)
        {
            try
            {
                var response = await "https://api.thecatapi.com/v1"
                .AppendPathSegment("favourites/")
                .SetQueryParam("api_key", AcessoCatApi.KeyCatAPI())
                .SetQueryParams(new
                {
                    image_id = fav.image_id,
                    sub_id = fav.sub_id
                })
                .PostJsonAsync(fav)
                .ReceiveString();

                return response;
            }
            catch (FlurlHttpTimeoutException ex)
            {
                throw new Exception($"Ops, tempo esgotado ao adicionar gatinho aos Favoritos. \nMensagem de erro retornado: {ex.Message}");
            }
        }
        public static async Task<string> DeletarFavorito(MeusFavoritos mfObject)
        {
            var retorno = await "https://api.thecatapi.com/v1"
                .AppendPathSegment($"favourites/{mfObject.Id}")
                .SetQueryParam("api_key", AcessoCatApi.KeyCatAPI())
                .DeleteAsync()
                .ReceiveString();

            return retorno;
        }
    }
}
