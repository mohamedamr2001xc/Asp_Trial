// <auto-generated>
// This code was generated by a kontent-generators-net tool
// (see https://github.com/kontent-ai/model-generator-net).
//
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// For further modifications of the class, create a separate file with the partial class.
// </auto-generated>

using System;
using System.Collections.Generic;
using Kontent.Ai.Delivery.Abstractions;

namespace DancingGoat.Models
{
    public partial class Cafe
    {
        public const string Codename = "cafe";
        public const string CityCodename = "city";
        public const string CountryCodename = "country";
        public const string EmailCodename = "email";
        public const string PhoneCodename = "phone";
        public const string PhotoCodename = "photo";
        public const string SitemapCodename = "sitemap";
        public const string StateCodename = "state";
        public const string StreetCodename = "street";
        public const string ZipCodeCodename = "zip_code";

        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public IEnumerable<IAsset> Photo { get; set; }
        public IEnumerable<ITaxonomyTerm> Sitemap { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public IContentItemSystemAttributes System { get; set; }
        public string ZipCode { get; set; }
    }
}