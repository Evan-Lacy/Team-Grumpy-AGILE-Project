using GrumpyAGILEProj.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpyAGILEProj.Models
{
    public class MovieCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "You have not put in a valid movie name.")]
        public string MovieTitle { get; set; }
        [Required]
        public Genre MovieGenre { get; set; }
        [Required]
        public MaturityRating MovieMaturity { get; set; }
        [MaxLength(5000)]
        public string MovieDescription { get; set; }
        public double RunTime { get; set; }
        
    }
}
