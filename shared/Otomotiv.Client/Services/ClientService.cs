using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Otomotiv.Api.Common.IOC;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Client.Services
{
    public class ClientService<T, E> : IClientService<T, E>, ISingletonService
    {
        private readonly JsonSerializerSettings _serializerSettings;

        public ClientService()
        {
            _serializerSettings = new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() };
        }

        public async Task<E> RestClientPostAsync(string baseUrl, string url, T requestObject)
        {
            string json = JsonConvert.SerializeObject(requestObject, _serializerSettings);
            try
            {
                RestClient restClient = new RestClient(baseUrl);

                var request = new RestRequest(url).AddJsonBody(json);
                var response = await restClient.PostAsync(request);
                ValidateResponse(response, json, url);
                E responseObject = JsonConvert.DeserializeObject<E>(response.Content);

                return responseObject;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<E> RestClientGetAsync(string url, T requestObject)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest();
                string json = "";
                if (requestObject != null)
                {
                    json = JsonConvert.SerializeObject(requestObject, _serializerSettings);
                    request.AddParameter("application/json", json, ParameterType.QueryString);
                }

                var response = await client.ExecuteGetAsync(request);
                ValidateResponse(response, json, url);
                E responseObject = JsonConvert.DeserializeObject<E>(response.Content);

                return responseObject;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        private void ValidateResponse(RestResponse response, string json, string url)
        {
            if (//response.StatusCode != HttpStatusCode.OK ||
                string.IsNullOrEmpty(response.Content))
            {
                throw new Exception($"Sağlayıcıdan cevap alınamadı: {response?.StatusCode} {response?.ErrorException?.Message ?? ""}");
            }
        }
    }
}
