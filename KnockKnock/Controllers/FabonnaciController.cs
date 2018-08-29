using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KnockKnock.Helpers;

namespace KnockKnock.Controllers
{   
    public class FibonnaciController : ApiController
    {
        [Route("api/Fibonacci")]
        [HttpGet]
        public HttpResponseMessage Get(long? n)
        {
            HttpResponseMessage res = null;
            try{
                var result = CalculateFab.GetNthFibonacci((long)n);
                res = Request.CreateResponse(HttpStatusCode.OK, result);
                return res;
            }
            catch(Exception ex)
            {
                if(ex.GetBaseException() is ArgumentOutOfRangeException)
                {
                    res= Request.CreateErrorResponse(HttpStatusCode.BadRequest, "no content");
                }
                else
                {
                    HttpError err = new HttpError("The request is invalid.");
                    res = Request.CreateErrorResponse( HttpStatusCode.BadRequest, err);
                }
                return res;
            }
                
        }
    }
}
