using GrumpyAGILEProj.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpyAGILEProj.Models
{
    public class MovieDetail
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieDescription { get; set; }
        public Genre MovieGenre { get; set; }
        public MaturityRating MovieMaturity { get; set; }
        public int? MovieRating { get; set; }

    }
}
