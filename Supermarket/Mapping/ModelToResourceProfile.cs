using AutoMapper;
using Microsoft.AspNetCore.DataProtection;
using Supermarket.Domain.Models;
using Supermarket.Extensions;
using Supermarket.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            // This syntax tells AutoMapper to use the new extension method to convert
            // our EUnitOfMeasurement value into a string containing its description.
            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                            opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));

        }
    }
}
