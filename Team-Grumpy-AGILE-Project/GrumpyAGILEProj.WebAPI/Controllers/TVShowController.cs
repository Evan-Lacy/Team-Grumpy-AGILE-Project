using GrumpyAGILEProj.Models;
using GrumpyAGILEProj.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GrumpyAGILEProj.WebAPI.Controllers
{
    public class TVShowController : ApiController
    {
        private TVShowService CreateTVShowService()
        {          
            var noteService = new TVShowService();
            return noteService;
        }

        public IHttpActionResult Get()
        {
            TVShowService tVShowService = CreateTVShowService();
            var shows = tVShowService.GetShows();
            return Ok(shows);
        }

        public IHttpActionResult Get(string title)
        {
            TVShowService tVShowService = CreateTVShowService();
            var show = tVShowService.GetTVShowsByName(title);
            return Ok(show);
        }

        public IHttpActionResult Post(TVShowCreate show)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateTVShowService();

            if (!service.CreateTVShow(show))
                return InternalServerError();

            return Ok();
        }
    }
}
