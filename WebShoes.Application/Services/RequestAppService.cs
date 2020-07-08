using AutoMapper;
using System.Collections.Generic;
using WebShoes.Application.Contracts.Services;
using WebShoes.Application.ViewModels;
using WebShoes.Core.Contracts.Services;
using WebShoes.Core.Entities;

namespace WebShoes.Application.Services
{
    public class RequestAppService : IRequestAppService
    {
        private readonly IRequestService _requestService;
        private readonly IMapper _mapper;

        public RequestAppService(IMapper mapper, IRequestService requestService)
        {
            _requestService = requestService;
            _mapper = mapper;
        }

        public void Add(RequestViewModel requestViewModel)
        {
            var requestEntity = _mapper.Map<RequestViewModel, RequestEntity>(requestViewModel);

            _requestService.Add(requestEntity);
        }

        public IEnumerable<RequestViewModel> GetAll()
        {
            var requestEntities = _requestService.GetAll();
            return _mapper.Map<IEnumerable<RequestEntity>, IEnumerable<RequestViewModel>>(requestEntities);
        }
    }
}
