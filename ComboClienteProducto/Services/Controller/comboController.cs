using BusinessLogic;
using Domain;
using System.Collections.Generic;
using System.Web.Http;

namespace Services.Controller
{
    public class comboController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Combos> Get()
        {
            return Manager.acquireCombo(); ;
        }
        // POST api/<controller>
        public void Post([FromBody]Combos combos)
        {
            Manager.saveCombo(combos);
        }
    }
}