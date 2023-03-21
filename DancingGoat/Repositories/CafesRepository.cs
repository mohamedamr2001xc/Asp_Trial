﻿using DancingGoat.Models;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters;
using Kontent.Ai.Urls.Delivery.QueryParameters.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DancingGoat.Repositories
{
    /// <summary>
    /// A demonstration of the Repository pattern
    /// </summary>
    public class CafesRepository : ICafesRepository
    {
        public IDeliveryClient DeliveryClient { get; }

        public CafesRepository(IDeliveryClientFactory deliveryClientFactory)
        {
            DeliveryClient = deliveryClientFactory.Get();
        }

        public async Task<IEnumerable<Cafe>> GetCafes(string language, string country = null, string order = "system.name")
        {
            List<IQueryParameter> parameters = new() { new LanguageParameter(language) };
            if(!string.IsNullOrEmpty(country))
            {
                parameters.Add(new EqualsFilter($"elements.{Cafe.CountryCodename}", "USA"));
            }
            if(!string.IsNullOrEmpty(order))
            {
                parameters.Add(new OrderParameter(order));
            }

            var response = await DeliveryClient.GetItemsAsync<Cafe>(parameters);
            
            return response.Items;
        }
    }
}
