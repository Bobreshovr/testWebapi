using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testWebapi.Controllers
{
    public class internalApiController : ApiController
    {
        [HttpGet]
        public IHttpActionResult get()
        {
            var sb = new testBobsEntities();

                 
            
            return Json(sb.Table);
        }

    }
}
