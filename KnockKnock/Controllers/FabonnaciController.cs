using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KnockKnock.Helpers;

namespace KnockKnock.Controllers
{
    public class FabonnaciController : ApiController
    {
        [Route("api/Fabonacci")]
        [HttpGet]
        public HttpResponseMessage Get(Int64? n)
        {
            HttpResponseMessage res = null;
                var fab = new CalculateFab();
            try{
                var result = fab.GetNthFibonacci((long)n);
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
