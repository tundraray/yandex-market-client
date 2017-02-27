using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Apix.Http.Client;
using Apix.Sync.YaMarket.Models;

namespace Apix.Sync.YaMarket
{
    public class YaMarketClient : HttpClientBase
    {
        private UrlBuilder UrlBuilder => new UrlBuilder();

        public YaMarketClient(ProxySettings proxy = null) : base(
            new Dictionary<string, string>()
            {
                {"X-App-Version", "3.71"},
                {"X-Platform", "ANDROID"},
                {"X-Device-Type", "SMARTPHONE"},
                {"User-Agent", "Yandex.Market/3.71 (Android/6.0.1; Nexus 5/google)"}
            }, proxy: proxy)
        {
        }
        
        public async Task<List<Offer>> ListOffers(int id, int count, CancellationToken cancellationToken)
        {
            var operationResult = await HttpClient.GetAsync(UrlBuilder.Offers(id),

                requestParameters: new RequestParameters<OffersResult>
                {
                    OnError = CommonBadResponse<OffersResult>
                });

            return operationResult?.Offers;
        }

        public async Task<List<Offer>> ListOffers(int id, int count, string latitude, string longitude, CancellationToken cancellationToken)
        {
            var operationResult = await HttpClient.GetAsync(UrlBuilder.Offers(id, latitude, longitude),

                requestParameters: new RequestParameters<OffersResult>
                {
                    OnError = CommonBadResponse<OffersResult>
                });

            return operationResult?.Offers;
        }

        public async Task<Content> Search(string query, CancellationToken cancellationToken)
        {
            var operationResult = await HttpClient.GetAsync(UrlBuilder.Search(query),

                requestParameters: new RequestParameters<SearchResult>
                {
                    OnError = CommonBadResponse<SearchResult>
                });

            return operationResult?.Redirects?.Content;
        }

        private Task<T> CommonBadResponse<T>(HttpResponseMessage response, CancellationToken cancellationToken)
            where T : class
        {
            switch (response.StatusCode)
            {

                case HttpStatusCode.Conflict:
                case HttpStatusCode.NotFound:
                    return Task.FromResult<T>(null);
                default:
                    DefaultBadResponseAction(response, cancellationToken);
                    break;
            }
            return Task.FromResult<T>(null);
        }
    }
}
