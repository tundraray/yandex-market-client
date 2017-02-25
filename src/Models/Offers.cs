using System.Collections.Generic;
using Newtonsoft.Json;

namespace Apix.Sync.YaMarket.Models
{
    public class Region
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "childCount")]
        public int ChildCount { get; set; }

        [JsonProperty(PropertyName = "country")]
        public int Country { get; set; }

    }

 

    public class Currency
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }

    public class Page
    {
        [JsonProperty(PropertyName = "number")]
        public int Number { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

    }

    public class ProcessingOptions
    {
        [JsonProperty(PropertyName = "adult")]
        public bool Adult { get; set; }

    }

    public class Context
    {
        [JsonProperty(PropertyName = "region")]
        public Region Region { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public Currency Currency { get; set; }

        [JsonProperty(PropertyName = "page")]
        public Page Page { get; set; }

        [JsonProperty(PropertyName = "processingOptions")]
        public ProcessingOptions ProcessingOptions { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

    }

    public class Price
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }



    public class Status
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }

    public class Rating
    {
        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "status")]
        public Status Status { get; set; }

    }

    public class Shop
    {
        [JsonProperty(PropertyName = "region")]
        public Region Region { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public Rating Rating { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        [JsonProperty(PropertyName = "registered")]
        public string Registered { get; set; }

    }

    public class Model
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

    }

    public class Phone
    {
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        [JsonProperty(PropertyName = "sanitized")]
        public string Sanitized { get; set; }

        [JsonProperty(PropertyName = "call")]
        public string Call { get; set; }

    }

    public class ShopRegion
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "nameRuGenitive")]
        public string NameRuGenitive { get; set; }

        [JsonProperty(PropertyName = "nameRuAccusative")]
        public string NameRuAccusative { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "childCount")]
        public int ChildCount { get; set; }

        [JsonProperty(PropertyName = "country")]
        public int Country { get; set; }

    }

    public class UserRegion
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "childCount")]
        public int ChildCount { get; set; }

        [JsonProperty(PropertyName = "country")]
        public int Country { get; set; }

    }

    public class Service
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }

    public class Option
    {
        [JsonProperty(PropertyName = "service")]
        public Service Service { get; set; }

    }

    public class Conditions
    {
        [JsonProperty(PropertyName = "price")]
        public Price Price { get; set; }

        [JsonProperty(PropertyName = "daysFrom")]
        public int DaysFrom { get; set; }

        [JsonProperty(PropertyName = "daysTo")]
        public int DaysTo { get; set; }

    }

    public class LocalOption
    {
        [JsonProperty(PropertyName = "conditions")]
        public Conditions Conditions { get; set; }

        [JsonProperty(PropertyName = "@default")]
        public bool Default { get; set; }

    }

    public class Delivery
    {
        [JsonProperty(PropertyName = "price")]
        public Price Price { get; set; }

        [JsonProperty(PropertyName = "free")]
        public bool Free { get; set; }

        [JsonProperty(PropertyName = "deliveryIncluded")]
        public bool DeliveryIncluded { get; set; }

        [JsonProperty(PropertyName = "carried")]
        public bool Carried { get; set; }

        [JsonProperty(PropertyName = "pickup")]
        public bool Pickup { get; set; }

        [JsonProperty(PropertyName = "downloadable")]
        public bool Downloadable { get; set; }

        [JsonProperty(PropertyName = "localStore")]
        public bool LocalStore { get; set; }

        [JsonProperty(PropertyName = "localDelivery")]
        public bool LocalDelivery { get; set; }

        [JsonProperty(PropertyName = "shopRegion")]
        public ShopRegion ShopRegion { get; set; }

        [JsonProperty(PropertyName = "userRegion")]
        public UserRegion UserRegion { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "brief")]
        public string Brief { get; set; }

        [JsonProperty(PropertyName = "inStock")]
        public bool InStock { get; set; }

        [JsonProperty(PropertyName = "options")]
        public List<Option> Options { get; set; }

        [JsonProperty(PropertyName = "localOptions")]
        public List<LocalOption> LocalOptions { get; set; }

    }

    public class Vendor
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "site")]
        public string Site { get; set; }

        [JsonProperty(PropertyName = "picture")]
        public string Picture { get; set; }

        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

    }

    public class PaymentOptions
    {
        [JsonProperty(PropertyName = "canPayByCard")]
        public bool CanPayByCard { get; set; }

    }

    public class BigPhoto
    {
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }

    public class Photo
    {
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }

    public class PreviewPhoto
    {
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }

    public class Offer
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "wareMd5")]
        public string WareMd5 { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "price")]
        public Price Price { get; set; }

        [JsonProperty(PropertyName = "cpa")]
        public bool Cpa { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "shop")]
        public Shop Shop { get; set; }

        [JsonProperty(PropertyName = "model")]
        public Model Model { get; set; }

        [JsonProperty(PropertyName = "onStock")]
        public bool OnStock { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public Phone Phone { get; set; }

        [JsonProperty(PropertyName = "delivery")]
        public Delivery Delivery { get; set; }

        [JsonProperty(PropertyName = "vendor")]
        public Vendor Vendor { get; set; }

        [JsonProperty(PropertyName = "warranty")]
        public bool Warranty { get; set; }

        [JsonProperty(PropertyName = "recommended")]
        public bool Recommended { get; set; }

        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        [JsonProperty(PropertyName = "variationCount")]
        public int VariationCount { get; set; }

        [JsonProperty(PropertyName = "paymentOptions")]
        public PaymentOptions PaymentOptions { get; set; }

        [JsonProperty(PropertyName = "bigPhoto")]
        public BigPhoto BigPhoto { get; set; }

        [JsonProperty(PropertyName = "photos")]
        public List<Photo> Photos { get; set; }

        [JsonProperty(PropertyName = "previewPhotos")]
        public List<PreviewPhoto> PreviewPhotos { get; set; }

        [JsonProperty(PropertyName = "cpaUrl")]
        public string CpaUrl { get; set; }

    }

    public class OffersResult
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "context")]
        public Context Context { get; set; }

        [JsonProperty(PropertyName = "offers")]
        public List<Offer> Offers { get; set; }

    }

}