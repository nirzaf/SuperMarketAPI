using AutoMapper;
using SuperMarketAPI.Models;
using SuperMarketAPI.Resources;


namespace SuperMarketAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
