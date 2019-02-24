using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebCoraApp.Application.ViewModels.Product;
using WebCoreApp.Data.Entities;

namespace WebCoraApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
