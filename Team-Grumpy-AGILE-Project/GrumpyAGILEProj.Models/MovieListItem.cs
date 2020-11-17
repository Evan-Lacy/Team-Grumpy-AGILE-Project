using GrumpyAGILEProj.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpyAGILEProj.Models
{
    public class MovieListItem
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        //public string MovieDescription { get; set; }
        //public Genre MovieGenre { get; set; }
        public MaturityRating MovieMaturity { get; set; }
        public double Runtime { get; set; }
        //[Display(Name = "Created")]
        //public DateTimeOffset CreatedUtc { get; set; }
    }
}
