using Adapter.Models.IBase;
using Adapter.Models.Sample;
using AutoMapper;
using MediatR;

namespace Adapter;

public interface ISender<TReqModel, TResModel> where TReqModel : IBaseReqModel where TResModel : IBaseResModel
{
    Task<TResModel> Send(TReqModel request);
}

public class Sender<TReqModel, TResModel>(IMediator mediator, IMapper mapper) 
    where TReqModel : IBaseReqModel
    where TResModel : IBaseResModel
{
    public async Task<TResModel> Send(TReqModel request)
    {
        var result = await mediator.Send(mapper.Map<TReqModel, IRequest<TResModel>>(request));
        return result;
    }
}