﻿using AutoMapper;

namespace Mango.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                /*config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();*/
            });

            return mappingConfig;
        }
    }
}
