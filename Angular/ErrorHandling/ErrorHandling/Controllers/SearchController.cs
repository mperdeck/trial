using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ErrorHandling.Models;
using System.Threading;

namespace ErrorHandling.Controllers
{
    public class SearchController : ApiController
    {
        // POST api/values
        public IEnumerable<Engagement> Post([FromBody]SearchParameters searchParameters)
        {
            switch(searchParameters.Code)
            {
                case "e":
                    throw new Exception("error!!");
                case "n":
                    return new List<Engagement>();
                case "t1":
                    Thread.Sleep(6000);
                    return new List<Engagement>();
                case "t2":
                    Thread.Sleep(3000);
                    return new List<Engagement>();
                case "2":
                    return new[] {
                        new Engagement {
                            Name = "name1a",
                            Description = "Description1a"
                        },
                        new Engagement {
                            Name = "name2a",
                            Description = "Description2a"
                        }
                    };
                case "e2":
                    HttpResponseMessage responseMessage = new HttpResponseMessage();
                    responseMessage.StatusCode = HttpStatusCode.InternalServerError;
                    responseMessage.ReasonPhrase = "Student not found";
                    responseMessage.Content = new StringContent("No student exists against provided student id");
                    throw new HttpResponseException(responseMessage);
                default:
                    return new[] {
                        new Engagement {
                            Name = "name1",
                            Description = "Description1"
                        },
                        new Engagement {
                            Name = "name2",
                            Description = "Description2"
                        }
                    };
            }
        }
    }
}

