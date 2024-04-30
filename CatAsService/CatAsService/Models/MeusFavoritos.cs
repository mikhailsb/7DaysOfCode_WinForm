using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CatAsService.Models
{
    public class MeusFavoritos
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("user_id")]
        public string User_Id { get; set; }

        [JsonProperty("image_id")]
        public string Image_Id { get; set; }

        [JsonProperty("sub_id")]
        public string Sub_Id { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        public static async Task<List<MeusFavoritos>> BuscarFavoritos()
        {
            var response = "https://api.thecatapi.com/v1"
                    .AppendPathSegment("favourites/")
                    .SetQueryParam("api_key", AcessoCatApi.KeyCatAPI())
                    .ToUri();
            var x = await response
                    .GetJsonAsync<List<MeusFavoritos>>();

            return x;
        }
        public static string BuscarFavos()
        {
            HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://api.thecatapi.com/v1/favourites/?api_key=live_1CSJmA9S1KetxHd5JS27UZpWmyu7HZtMMOgVnj7eQ5lskUdZFD34SXDWAcxL5LYs");
            //requisicao.Headers.Add("api_key", AcessoCatApi.KeyCatAPI());
            HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();

            int cont;
            byte[] buffer = new byte[1000];
            StringBuilder sb = new StringBuilder();
            string temp;
            Stream stream = resposta.GetResponseStream();
            do
            {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);
            } while (cont > 0);

            return sb.ToString();
        }
        public static List<MeusFavoritos> Deserialize(string Json)
        {
            List<MeusFavoritos> favoritos = JsonConvert.DeserializeObject<List<MeusFavoritos>>(Json);
            return favoritos;
        }
    }
    public partial class Image
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
