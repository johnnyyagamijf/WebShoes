using System;
using System.Collections.Generic;
using WebShoes.Core.Contracts.Repositories;
using WebShoes.Core.Contracts.Services;
using WebShoes.Core.Entities;

namespace WebShoes.Core.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;

        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public void Add(RequestEntity requestEntity)
        {
            _requestRepository.Add(requestEntity);
        }

        public IEnumerable<RequestEntity> GetAll()
        {
            return _requestRepository.GetAll();
        }
    }
}
