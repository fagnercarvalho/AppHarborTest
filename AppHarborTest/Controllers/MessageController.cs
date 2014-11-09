using System.Web.Http;

namespace AppVeyorTest.Controllers
{
    [RoutePrefix("api/message")]
    public class MessageController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetMessage()
        {
            return this.Ok("Hello world!");
        }
    }
}