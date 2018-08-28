using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KnockKnock.Helpers;
using KnockKnock.Enums;

namespace KnockKnock.Controllers
{
    public class TriangleTypeController : ApiController
    {
        [Route("api/TriangleType")]
        [HttpGet]
        public HttpResponseMessage Get(int? a, int? b, int? c)
        {
            HttpResponseMessage res = null;
            var triangleType = new TriangleTypeHelper();
            try
            {
                var result = triangleType.GetTriangleType((int)a, (int)b, (int)c);
                res = Request.CreateResponse(HttpStatusCode.OK, result.ToString());
                return res;
            }
            catch (Exception ex)
            {
                {
                    res = Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
                }
                return res;
            }

        }
    }
}
