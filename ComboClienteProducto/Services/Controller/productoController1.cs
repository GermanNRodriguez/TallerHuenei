using Domain;
using System;
using System.Collections.Generic;
using BusinessLogic;
using System.Web.Http;

namespace Services.Controller
{
    public class productoController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            return Manager.acquireProduct();
        }

    }
}