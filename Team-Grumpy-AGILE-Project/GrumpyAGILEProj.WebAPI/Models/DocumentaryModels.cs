using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrumpyAGILEProj.WebAPI.Models
{
    public class Documentary
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public MaturityRating MaturityRating { get; set; }
        [Required]
        public DocGenre DocGenre { get; set; }
        [Required]
        public double RunTime { get; set; }

    }