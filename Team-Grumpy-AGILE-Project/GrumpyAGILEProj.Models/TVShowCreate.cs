using GrumpyAGILEProj.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpyAGILEProj.Models
{
    public class TVShowCreate
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        public TVMaturityRating TVMaturityRating { get; set; }
        [Required]
        public double AverageEpisodeLength { get; set; }
        public double TotalEpisodes { get; set; }
        public double TotalSeasons { get; set; }

    }
}
