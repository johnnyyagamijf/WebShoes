using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShoes.Application.Contracts.Services;
using WebShoes.Application.ViewModels;

namespace WebShoes.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Request")]
    public class RequestController : Controller
    {
        private readonly IRequestAppService _requestAppService;
        public RequestController(IRequestAppService requestAppService)
        {
            _requestAppService = requestAppService;
        }

        public IActionResult Create(RequestViewModel requestViewModel)
        {
            _requestAppService.Add(requestViewModel);

            return Ok("Successo");
        }
    }
}