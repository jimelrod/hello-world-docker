using HelloWorld.Web.Api.Models;
using System;
using System.Net;
using System.Web.Http;

namespace HelloWorld.Web.Api.Controllers
{
    public class HealthCheckController : ApiController
    {
        public IHttpActionResult Get()
        {
            IHttpActionResult response;

            try
            {
                response = Ok(new HelloWorldResponse<string>
                {
                    IsSuccessful = true,
                    Body = "Hello, world!"
                });
            }
            catch (Exception ex)
            {
                response = Content(HttpStatusCode.InternalServerError, new HelloWorldResponse<Exception>
                {
                    IsSuccessful = false,
                    Body = ex
                });
            }

            return response;
        }

        public IHttpActionResult Get(int id)
        {
            IHttpActionResult response;

            try
            {
                response = Ok(new HelloWorldResponse<string>
                {
                    IsSuccessful = true,
                    Body = $"Hello, no. {id}!"
                });
            }
            catch(Exception ex)
            {
                response = Content(HttpStatusCode.InternalServerError, new HelloWorldResponse<Exception>
                {
                    IsSuccessful = false,
                    Body = ex
                });
            }

            return response;
        }
    }
}
