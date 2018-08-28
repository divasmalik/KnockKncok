using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KnockKnock.Helpers;

namespace KnockKnock.Controllers
{
    public class ReverseStringController : ApiController
    {

        [Route("api/ReverseWords")]
        [HttpGet]
        public HttpResponseMessage Get(string sentence="")
        {
            HttpResponseMessage res = null;
            var rvr_str = new ReverserStringHelper();
            try
            {
                var result = rvr_str.ReverseString(sentence);
                res = Request.CreateResponse(HttpStatusCode.OK, result);
                return res;
            }
            catch (Exception ex)
            {
                    res = Request.CreateErrorResponse(HttpStatusCode.BadRequest,ex);
                
                return res;
            }

        }
    }
}
