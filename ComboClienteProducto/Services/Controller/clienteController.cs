using BusinessLogic;
using Domain;
using System.Collections.Generic;
using System.Web.Http;

namespace Services.Controller
{
    public class clienteController : ApiController
    {
        public IEnumerable<Client> Get()
        {
            return Manager.acquireClient();
        }

    }
}
