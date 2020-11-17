using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpyAGILEProj.Data
{
    public class Movie
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
        public double RunTime { get; set; }
        [Required]
        public MaturityRating MaturityRating { get; set; }

        public int? Rating { get; set; }
    }

    public enum Genre
    {
        Horror = 1,
        RomCom,
        SciFi,
        Action,
        Musical,
        Drama,
        Mystery
    }

    public enum MaturityRating
    {
        G = 1,
        PG,
        PG_13,
        R,
        NC_17
    }
}
