using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CatAsService.Uteis
{
    public class ConsultaAPI
    {
        public static string BuscaRacasGatoJson()
        {
            HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://api.thecatapi.com/v1/breeds");
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
        public static string BuscaImagemGatoJson(string uri)
        {
            HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create(uri);
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
    }
}
