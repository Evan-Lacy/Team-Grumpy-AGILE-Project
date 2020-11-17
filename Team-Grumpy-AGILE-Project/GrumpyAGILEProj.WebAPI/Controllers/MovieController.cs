using GrumpyAGILEProj.Models;
using GrumpyAGILEProj.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GrumpyAGILEProj.WebAPI.Controllers
{
    public class MovieController : ApiController
    {
        private MovieService CreateMovieService()
        {
            var movieService = new MovieService();
            return movieService;
        }

        public IHttpActionResult Get()
        {
            MovieService movieService = CreateMovieService();
            var movies = movieService.GetMovies();
            return Ok(movies);
        }

        public IHttpActionResult Get(int id)
        {
            MovieService movieService = CreateMovieService();
            var movie = movieService.GetMovieById(id);
            return Ok(movie);
        }

        public IHttpActionResult Post(MovieCreate movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = CreateMovieService();

            if (!service.CreateMovie(movie))
            {
                return InternalServerError();//500
            }

            return Ok();//200
        }
    }
}
