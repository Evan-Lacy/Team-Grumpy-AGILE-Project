using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpyAGILEProj.Models
{ 
    public class Documentary
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public DocGenre DocGenre { get; set; }
        public double RunTime { get; set; }

    }
    public class DocumentaryDBContext : DbContext
    {
        public DbSet<Documentary> Documentaries { get; set; }

    }


}
    