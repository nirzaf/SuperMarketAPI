using AutoMapper;
using SuperMarketAPI.Models;
using SuperMarketAPI.Resources;

namespace SuperMarketAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}
