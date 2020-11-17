using GrumpyAGILEProj.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpyAGILEProj.Models
{
    public class TVShowDetail
    {
        public int ShowId { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
        public TVMaturityRating TVMaturityRating { get; set; }
        public double AverageEpisodeLength { get; set; }
        public double TotalEpisodes { get; set; }
        public double TotalSeasons { get; set; }
    }
}
