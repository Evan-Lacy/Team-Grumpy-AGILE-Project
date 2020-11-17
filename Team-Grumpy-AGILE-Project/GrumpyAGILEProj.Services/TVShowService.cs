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
    public class TVShowService
    {
        public bool CreateTVShow(TVShowCreate model)
        {
            var entity =
                new TVShow()
                {
                    Title = model.Title,
                    Description = model.Description,
                    Genre = model.Genre,
                    TVMaturityRating = model.TVMaturityRating,
                    AverageEpisodeLength = model.AverageEpisodeLength,
                    TotalEpisodes = model.TotalEpisodes,
                    TotalSeasons = model.TotalSeasons,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Shows.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        
        public IEnumerable<TVShowListItem> GetShows()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Shows
                        .Select(
                            e =>
                                new TVShowListItem
                                {
                                    TVShowId = e.TVShowId,
                                    Title = e.Title,
                                    Rating = e.Rating
                                }
                        );
                return query.ToArray();
            }
        }

        public TVShowDetail GetTVShowsByName(string title)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Shows
                        .Single(e => e.Title == title);
                return
                    new TVShowDetail
                    {
                        ShowId = entity.ShowID,
                        Title = entity.Title,
                        Rating = entity.Rating,
                        Description = entity.Description,
                        Genre = entity.Genre,
                        TVMaturityRating = entity.TVMaturityRating,
                        AverageEpisodeLength = entity.AverageEpisodeLength,
                        TotalEpisodes = entity.TotalEpisodes,
                        TotalSeasons = entity.TotalSeasons
                    };
            }
        }
    }
}
