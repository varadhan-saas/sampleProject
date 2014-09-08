using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPISample.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalcController : ApiController
    {
        [HttpGet]

        public int Calculator([FromUri]int a,[FromUri]int b,[FromUri]string op)
        {
            if (op.Equals("add"))
                return a + b;
            if(op.Equals("sub"))
                return a-b;
            return 0;
        }

    }
}
