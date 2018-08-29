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

            try
            {
                var result = ReverserStringHelper.ReverseString(sentence);
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
