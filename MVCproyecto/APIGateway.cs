using MVCproyecto.Models;
using Newtonsoft.Json;
using System.Net;

namespace MVCproyecto
{
    public class APIGateway
    {

        private string _url = "http://localhost:5108/api/ClienteControlador";
        private HttpClient _client = new HttpClient();

        public List<Cliente> ListCliente()
        {
            List<Cliente> clientes = new List<Cliente>();

            if(_url.Trim().Substring(0,5).ToLower() == "https")
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }

            try
            {
                HttpResponseMessage respuesta = _client.GetAsync(_url).Result;

                if (respuesta.IsSuccessStatusCode)
                {
                    string resultado = respuesta.Content.ReadAsStringAsync().Result;

                    var datallama = JsonConvert.DeserializeObject<List<Cliente>>(resultado);

                    if (datallama != null)
                    {
                        clientes = datallama;
                    }
                }
                else
                {
                    string resultado = respuesta.Content.ReadAsStringAsync().Result;
                    throw new Exception("Un error a ocurrido " + resultado);
                }
            }
            catch (Exception)
            {
                throw;
            }

            finally { }

            return clientes;
        }

        private string _url2 = "http://localhost:5108/api/ProductoControlador";
        private HttpClient _client2 = new HttpClient();

        //Parte de productos
        public List<Producto> ListProducto()
        {
            List<Producto> producto = new List<Producto>();

            if (_url.Trim().Substring(0, 5).ToLower() == "https")
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }

            try
            {
                HttpResponseMessage respuesta = _client2.GetAsync(_url2).Result;

                if (respuesta.IsSuccessStatusCode)
                {
                    string resultado = respuesta.Content.ReadAsStringAsync().Result;

                    var datallama = JsonConvert.DeserializeObject<List<Producto>>(resultado);

                    if (datallama != null)
                    {
                        producto = datallama;
                    }
                }
                else
                {
                    string resultado = respuesta.Content.ReadAsStringAsync().Result;
                    throw new Exception("Un error a ocurrido " + resultado);
                }
            }
            catch (Exception)
            {
                throw;
            }

            finally { }

            return producto;
        }
    }
}
