using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Apix.Http.Client;

namespace Apix.Sync.YaMarket
{
    internal class UrlBuilder
    {
        private const string apiUrl = "https://mobile.market.yandex.net/market/content/v2.0.1/";

        private const string OffersUrl = "models/{1}/offers?&page=1&count={2}&sort=PRICE&how=ASC&groupBy=SHOP&show_discounts=1&fields=OFFER_DISCOUNT%2COFFER_SHOP%2COFFER_DELIVERY%2CSHOP_RATING%2COFFER_VENDOR%2CVENDOR_ALL%2COFFER_PHOTO&uuid={0}";


        public string Offers(int id, int size =5)
        {
            return string.Format("{0}{1}", apiUrl, string.Format(OffersUrl, Guid.NewGuid().ToString("N"), id, size));
        }

        public string Search(string query)
        {
            return string.Format("https://mobile.market.yandex.net/market/content/v2.0.2/redirect?redirect_types=CATALOG,MODEL,PROMO_PAGE,VENDOR,SEARCH&contents=REDIRECT_MODEL,REDIRECT_VENDOR,REDIRECT_CATALOG&count=1&text={0}&lac=7837&cellid=8310723&operatorid=2&countrycode=250&signalstreng&standart&lac=7837&cellid=8310723&operatorid=2&countrycode=250&signalstrength=0&wifinetworks=FAF082B8DFC4:-32,78542EDFBDE5:-61,14CC203F6231:-68,E84DD0EED178:-71,90F652B145D0:-76,0023CDCE765C:-82,E894F66FA4B2:-87&uuid={1}&sections=medicine", WebUtility.UrlEncode( query), Guid.NewGuid().ToString("N"));
        }

    }
}