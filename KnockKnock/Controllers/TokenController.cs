using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnock.Controllers
{
    public class TokenController : ApiController
    {
        [Route("api/Token")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            HttpResponseMessage res = null;
            var Token = "bbee41b9-2da3-4851-933a-b16f6f4f3fba";

            try
            {
                res = Request.CreateResponse(HttpStatusCode.OK, Token);

                return res;
            }
            catch (Exception ex)
            {
                res = Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);

                return res;
            }

        }
    }
}