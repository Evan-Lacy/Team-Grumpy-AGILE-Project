using GrumpyAGILEProj.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GrumpyAGILEProj.WebAPI.Controllers
{

    public class DocController : ApiController
    {
        private Documentary CreateDocumentary()
        {

        }

        public IHttpActionResult Get()
        {
            Documentary documentary = CreateDocumentary();
            var documentaries = documentary.GetDocumentaries();
            return Ok(documentaries);
        }

        public IHttpActionResult Post(DocumentaryCreate documentary)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateDocumentary();

            if (!service.CreateDocumentary(documentary))
                return InternalServerError();

            return Ok();
        }
    }
}



