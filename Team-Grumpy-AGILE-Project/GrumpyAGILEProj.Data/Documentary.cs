using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpyAGILEProj.Data
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

    public enum DocGenre
    {
        Expository = 1,
        Poetic,
        Essayistic,
        Observational,
        Participatory,
        Performance,
        Interview,
        Dramatization,
        Mixed,
        Animation
    }
}
