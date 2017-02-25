using System;
using System.Security.Cryptography;
using System.Text;
using Apix.Http.Client;

namespace Apix.Sync.YaMarket.Client
{
    internal class UrlBuilder
    {
        private const string apiUrl = "https://mobile.market.yandex.net/market/content/v2.0.1/";

        private const string OffersUrl = "models/{1}/offers?&page=1&count={2}&sort=PRICE&how=ASC&groupBy=SHOP&show_discounts=1&fields=OFFER_DISCOUNT%2COFFER_SHOP%2COFFER_DELIVERY%2CSHOP_RATING%2COFFER_VENDOR%2CVENDOR_ALL%2COFFER_PHOTO&uuid={0}";

        public string Offers(int id, int size =5)
        {
            return string.Format("{0}{1}", apiUrl, string.Format(OffersUrl, Guid.NewGuid(), id, size));
        }

    }
}