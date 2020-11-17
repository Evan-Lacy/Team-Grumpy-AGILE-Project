using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpyAGILEProj.Data
{
    public class TVShow
    {
        [Key]
        public int Id { get; set; }
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

    public enum TVMaturityRating
    {
        TV_Y = 1,
        TV_Y7,
        TV_Y7_FV,
        TV_G,
        TV_PG,
        TV_14,
        TV_MA
    }

    
}
