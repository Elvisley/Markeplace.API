using System;
using System.Collections.Generic;
using Marketplace.API.Aplication.Services;
using Marketplace.API.Domain.RepositoriesContracts;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.API.Service.Controllers
{
    [Route("api/[controller]")]
    public class MarketplaceController : Controller
    {
        private readonly ServiceMarketplace _serviceMarketplace;

        public MarketplaceController(ServiceMarketplace _serv)
        {
            _serviceMarketplace = _serv;
        }

        [HttpGet]
        public IEnumerable<Domain.Domain.Marketplace> Get()
        {
            return _serviceMarketplace.GetAll();
        }

        [HttpPost]
        public Domain.Domain.Marketplace Store(Domain.Domain.Marketplace marketplace){

            return _serviceMarketplace.Create(marketplace);

        }
    }
}
