using System;
using System.Collections.Generic;
using Marketplace.API.Domain.RepositoriesContracts;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.API.Service.Controllers
{
    [Route("api/[controller]")]
    public class MarketplaceController : Controller
    {
        private readonly IRepositoryMarketplace _rep;

        public MarketplaceController(IRepositoryMarketplace _rep)
        {
            this._rep = _rep;
        }

        [HttpGet]
        public IEnumerable<Domain.Domain.Marketplace> Get()
        {
            return _rep.GetAll();
        }
    }
}
