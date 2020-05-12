using BusinessLogic;
using Domain;
using System.Collections.Generic;
using System.Web.Http;

namespace Services.Controller
{
    public class combocpController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ComboCP> Get(int id)
        {
            return Manager.acquireCP(id);
        }

    }
}