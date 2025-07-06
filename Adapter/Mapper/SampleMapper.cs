using AutoMapper;

namespace Adapter.Mapper;

public class SampleMapper : Profile
{
    public SampleMapper()
    {
        CreateMap<Adapter.Models.Sample.ReqModel, Core.Dto.Sample.ReqModel>();
        CreateMap<Core.Dto.Sample.ResModel, Adapter.Models.Sample.ResModel>();
    }
}