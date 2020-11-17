using GrumpyAGILEProj.Data;
using GrumpyAGILEProj.Models;
using GrumpyAGILEProj.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpyAGILEProj.Services
{
    public class MovieService
    {
        //private readonly int _movieId;

        //public MovieService(int movieId)
        //{
        //    _movieId = movieId;
        //}

        public bool CreateMovie(MovieCreate model)
        {
            var entity = new Movie()
            {
                Title = model.MovieTitle,
                Description = model.MovieDescription,
                Genre = model.MovieGenre,
                RunTime = model.RunTime,
                MaturityRating = model.MovieMaturity
            };

            using(var ctx = new ApplicationDbContext())
            {
                ctx.Movies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<MovieListItem> GetMovies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .Movies
                    .Select
                    (e => new MovieListItem
                    {
                        MovieId = e.Id,
                        MovieTitle = e.Title,
                        MovieMaturity = e.MaturityRating,
                        Runtime = e.RunTime
                    }
                    );
                return query.ToArray();
            }
        }

        public MovieDetail GetMovieById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                ctx.Movies.Single(e => e.Id == id);
                return new MovieDetail
                {
                    MovieId = entity.Id,
                    MovieTitle = entity.Title,
                    MovieDescription = entity.Description,
                    MovieGenre = entity.Genre,
                    MovieMaturity = entity.MaturityRating,
                    MovieRating = entity.Rating
                };
            }
        }
    }
}
