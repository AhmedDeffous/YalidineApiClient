using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
    public class YalidineAPI
    {
        public string BaseUrl { get; private set; } = "https://api.yalidine.app/v1/";

        public string ApiId { get; } = "X-API-ID";

        public string ApiToken { get; } = "X-API-TOKEN";

        public string ApiIdValue { get; set; } = "";

        public string ApiTokenValue { get; set; } = "";

        public string LastResponse { get; private set; } = "";

        public YalidineAPI(string API, String Token, string Url)
        {
            ApiIdValue = API;
            ApiTokenValue = Token;
            BaseUrl = Url;
        }

        public async Task<YWilayas> GetWilayasAsync()
        {

            using (HttpClient w = new HttpClient())
            {
                try
                {
                    if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                    if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");

                    w.BaseAddress = new Uri(this.BaseUrl + "wilayas/");
                    w.DefaultRequestHeaders.Add(ApiId, ApiIdValue);
                    w.DefaultRequestHeaders.Add(ApiToken, ApiTokenValue);
                    HttpResponseMessage response = await w.GetAsync(w.BaseAddress);

                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();


                    YWilayas Yw = JsonSerializer.Deserialize<YWilayas>(responseBody);

                    LastResponse = responseBody;

                    Yw.Success = true;
                    Yw.Tag = "OK";
                    return Yw;
                }
                catch (HttpRequestException e)
                {
                    YWilayas Yw = new YWilayas();
                    // Handle any errors that occur during the request
                    Console.WriteLine($"Request error: {e.Message}");
                    LastResponse = e.Message;
                    Yw.Success = false;
                    Yw.Tag = e.Message;
                    return Yw;
                }
            }


        }
        public async Task<YCommunes> GetComunesAsync(int IdWilaya)
        {

            using (HttpClient w = new HttpClient())
            {
                try
                {
                    if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                    if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");

                    w.BaseAddress = new Uri(this.BaseUrl + "communes/?wilaya_id=" + IdWilaya);
                    w.DefaultRequestHeaders.Add(ApiId, ApiIdValue);
                    w.DefaultRequestHeaders.Add(ApiToken, ApiTokenValue);
                    HttpResponseMessage response = await w.GetAsync(w.BaseAddress);

                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();


                    YCommunes Yc = JsonSerializer.Deserialize<YCommunes>(responseBody);

                    LastResponse = responseBody;
                    // Console.WriteLine(responseBody);
                    Yc.Success = true;
                    Yc.Tag = "OK";
                    return Yc;
                }
                catch (HttpRequestException e)
                {
                    YCommunes Yc = new YCommunes();
                    Yc.Tag = e.Message;
                    Yc.Success = false;
                    Console.WriteLine($"Request error: {e.Message}");
                    LastResponse = e.Message;
                    return Yc;
                }
            }


        }

        public async Task<YFees> GetYFeess(int FromWilaya, int ToWilaya)
        {
            if (FromWilaya < 1 || FromWilaya > 58) return new YFees();
            if (ToWilaya < 1 || ToWilaya > 58) return new YFees();
            using (HttpClient w = new HttpClient())
            {
                try
                {
                    if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                    if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");

                    w.BaseAddress = new Uri(this.BaseUrl + $"fees/?from_wilaya_id={FromWilaya}&to_wilaya_id={ToWilaya}");
                    w.DefaultRequestHeaders.Add(ApiId, ApiIdValue);
                    w.DefaultRequestHeaders.Add(ApiToken, ApiTokenValue);
                    HttpResponseMessage response = await w.GetAsync(w.BaseAddress);

                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    YFees Yw = JsonSerializer.Deserialize<YFees>(responseBody);

                    LastResponse = responseBody;
                    // Console.WriteLine(responseBody);
                    return Yw;
                }
                catch (HttpRequestException e)
                {
                    // Handle any errors that occur during the request
                    Console.WriteLine($"Request error: {e.Message}");
                    LastResponse = e.Message;
                    return new YFees();
                }
            }


        }
        public async Task<YCenters> GetCentersAsync(int wilaya_id)
        {
            int PageId = 1;
            using (HttpClient w = new HttpClient())
            {
                try
                {
                    if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                    if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");
                    w.BaseAddress = new Uri(this.BaseUrl + $"centers/?wilaya_id={wilaya_id}&page_size=100&page={PageId}");
                    w.DefaultRequestHeaders.Add(ApiId, ApiIdValue);
                    w.DefaultRequestHeaders.Add(ApiToken, ApiTokenValue);
                    HttpResponseMessage response = await w.GetAsync(w.BaseAddress);

                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    YCenters Yw = JsonSerializer.Deserialize<YCenters>(responseBody);
                    Yw.Success = true;
                    Yw.Tag = "Ok";
                    LastResponse = responseBody;
                    // Console.WriteLine(responseBody);
                    return Yw;
                }
                catch (HttpRequestException e)
                {
                    YCenters Yw = new YCenters();
                    Yw.Success = false;
                    Yw.Tag = e.Message;
                    Console.WriteLine($"Request error: {e.Message}");
                    LastResponse = e.Message;
                    return new YCenters();
                }
            }


        }

        public async Task<YParcels> GetParcelsAsync(int PageId)
        {
            if (PageId < 1) PageId = 1;
            using (HttpClient w = new HttpClient())
            {
                try
                {
                    if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                    if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");
                    w.BaseAddress = new Uri(this.BaseUrl + $"parcels/?page_size=100&page={PageId}");
                    w.DefaultRequestHeaders.Add(ApiId, ApiIdValue);
                    w.DefaultRequestHeaders.Add(ApiToken, ApiTokenValue);
                    HttpResponseMessage response = await w.GetAsync(w.BaseAddress);


                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    LastResponse = responseBody;


                    YParcels Yw = System.Text.Json.JsonSerializer.Deserialize<YParcels>(responseBody);
                    Yw.Success = true;
                    Yw.Tag = "Ok";
                    return Yw;

                }
                catch (HttpRequestException e)
                {
                    YParcels Yw = new YParcels();
                    Yw.Success = true;
                    Yw.Tag = e.Message;
                    Console.WriteLine($"Request error: {e.Message}");
                    LastResponse = e.Message;
                    return Yw;
                }
            }


        }

        public async Task<YParcels> GetParcelsAsync(int PageId, string TrakingIds)
        {
            using (HttpClient w = new HttpClient())
            {
                try
                {
                    if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                    if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");
                    w.BaseAddress = new Uri(this.BaseUrl + $"parcels/?page_size=100&page={PageId}&tracking={TrakingIds}");
                    w.DefaultRequestHeaders.Add(ApiId, ApiIdValue);
                    w.DefaultRequestHeaders.Add(ApiToken, ApiTokenValue);
                    HttpResponseMessage response = await w.GetAsync(w.BaseAddress);

                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    LastResponse = responseBody;
                    YParcels Yw = JsonSerializer.Deserialize<YParcels>(responseBody);
                    Yw.Success = true;
                    Yw.Tag = "Ok";
                    return Yw;
                }
                catch (HttpRequestException e)
                {
                    YParcels Yw = new YParcels();
                    // Handle any errors that occur during the request
                    Console.WriteLine($"Request error: {e.Message}");
                    LastResponse = e.Message;
                    Yw.Success = false;
                    Yw.Tag = e.Message;
                    return Yw;
                }
            }


        }
        public async Task<YParcels> GetParcelsAsync(int PageId, bool freeshipping, int to_wilaya_id)
        {
            using (HttpClient w = new HttpClient())
            {
                try
                {
                    if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                    if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");
                    string to = "";
                    if (to_wilaya_id >= 1 && to_wilaya_id <= 58) to = "&to_wilaya_id=" + to_wilaya_id;
                    w.BaseAddress = new Uri(this.BaseUrl + $"parcels/?page_size=100&page={PageId}&freeshipping={freeshipping.ToString().ToLower()}" + to);
                    w.DefaultRequestHeaders.Add(ApiId, ApiIdValue);
                    w.DefaultRequestHeaders.Add(ApiToken, ApiTokenValue);
                    HttpResponseMessage response = await w.GetAsync(w.BaseAddress);

                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    LastResponse = responseBody;
                    YParcels Yw = JsonSerializer.Deserialize<YParcels>(responseBody);

                    return Yw;
                }
                catch (HttpRequestException e)
                {
                    // Handle any errors that occur during the request
                    Console.WriteLine($"Request error: {e.Message}");
                    LastResponse = e.Message;
                    return new YParcels();
                }
            }


        }
        public async Task<YParcels> GetParcelsAsync(int PageId, bool freeshipping)
        {
            using (HttpClient w = new HttpClient())
            {
                try
                {
                    if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                    if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");
                    w.BaseAddress = new Uri(this.BaseUrl + $"parcels/?page_size=100&page={PageId}&freeshipping={freeshipping.ToString().ToLower()}");
                    w.DefaultRequestHeaders.Add(ApiId, ApiIdValue);
                    w.DefaultRequestHeaders.Add(ApiToken, ApiTokenValue);
                    HttpResponseMessage response = await w.GetAsync(w.BaseAddress);

                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    LastResponse = responseBody;
                    YParcels Yw = JsonSerializer.Deserialize<YParcels>(responseBody);

                    return Yw;
                }
                catch (HttpRequestException e)
                {
                    // Handle any errors that occur during the request
                    Console.WriteLine($"Request error: {e.Message}");
                    LastResponse = e.Message;
                    return new YParcels();
                }
            }


        }

        public async Task<YLabels> GetParcelLabel(string Url)
        {
            YLabels Yw = new YLabels();
            using (HttpClient w = new HttpClient())
            {
                try
                {
                    if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                    if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");
                    w.BaseAddress = new Uri(Url);
                    HttpResponseMessage response = await w.GetAsync(w.BaseAddress);
                    response.EnsureSuccessStatusCode();
                    byte[] responseBody = await response.Content.ReadAsByteArrayAsync();
                    Yw.LYLabels.Add(responseBody);
                    Yw.Success = true;
                    Yw.Tag = "Ok";
                    return Yw;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                    LastResponse = e.Message;
                    Yw.Success = false;
                    Yw.Tag = e.Message;
                    return Yw;
                }
            }
        }

        public async Task<YParcelHistories> GetYParcelHistoriesAsync(int PageId, string TrakingIds)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                    if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");
                    HttpClient w = new HttpClient();
                    w.BaseAddress = new Uri(this.BaseUrl + $"histories/?page_size=100&page={PageId}&tracking={TrakingIds}");
                    w.DefaultRequestHeaders.Add(ApiId, ApiIdValue);
                    w.DefaultRequestHeaders.Add(ApiToken, ApiTokenValue);
                    HttpResponseMessage response = await w.GetAsync(w.BaseAddress);

                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    LastResponse = responseBody;
                    YParcelHistories Yw = JsonSerializer.Deserialize<YParcelHistories>(responseBody);
                    Yw.Success = true;
                    Yw.Tag = "Ok";
                    return Yw;
                }
                catch (HttpRequestException e)
                {
                    YParcelHistories Yw = new YParcelHistories();
                    Yw.Success = false;
                    Yw.Tag = e.Message;
                    Console.WriteLine($"Request error: {e.Message}");
                    LastResponse = e.Message;
                    return Yw;
                }
            }


        }

        public async Task<YCreateOrdersResults> CreateParcel(YParcelToCreate parcel)
        {
            YCreateOrdersResults Results = new YCreateOrdersResults();
            try
            {
                if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");

                List<YParcelToCreate> l = new List<YParcelToCreate>();
                l.Add(parcel);
                string jsonData = JsonSerializer.Serialize(l);
                HttpClient w = new HttpClient();
                Uri url = new Uri(this.BaseUrl + $"parcels/");
                w.DefaultRequestHeaders.Add(ApiId, ApiIdValue);
                w.DefaultRequestHeaders.Add(ApiToken, ApiTokenValue);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await w.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                Results = JsonSerializer.Deserialize<YCreateOrdersResults>(responseBody);
                Results.Success = true;
                Results.Tag = "OK";
            }
            catch (HttpRequestException e)
            {
                Results.Success = false;
                Results.Tag = e.Message;
                Console.WriteLine($"Request error: {e.Message}");
            }
            return Results;
        }

        public async Task<YDeleteParcelResponses> DeleteParcel(string TrakingIds)
        {
            YDeleteParcelResponses o = new YDeleteParcelResponses();

            using (HttpClient w = new HttpClient())
            {
                try
                {
                    if (ApiIdValue.Length == 0) throw new Exception("Api Id not Valide");
                    if (ApiTokenValue.Length == 0) throw new Exception("Api Token not Valide");

                    Uri url = new Uri(this.BaseUrl + $"parcels/?tracking={TrakingIds}");
                    w.DefaultRequestHeaders.Add(ApiId, ApiIdValue);
                    w.DefaultRequestHeaders.Add(ApiToken, ApiTokenValue);

                    HttpResponseMessage response = await w.DeleteAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<YDeleteParcelResponse> l = JsonSerializer.Deserialize<List<YDeleteParcelResponse>>(responseBody);
                    if (l == null)
                        l = new List<YDeleteParcelResponse>();
                    
                    o.ListDeleteParcelResponses = l;
                    o.Success = true;
                    o.Tag = "Ok";
                 }
                catch (HttpRequestException e)
                {
                    o.Success = false;
                    o.Tag = e.Message;
                 }
            }
            return o;
        }
    }
}
