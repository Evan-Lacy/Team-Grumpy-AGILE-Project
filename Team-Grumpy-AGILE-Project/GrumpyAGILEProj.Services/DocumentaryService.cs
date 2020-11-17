using GrumpyAGILEProj.Models;
using GrumpyAGILEProj.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpyAGILEProj.Services
{
    public class DocumentaryService
    {
        //private readonly Guid _id;

        //public DocumentaryService(Guid id)
        //{
        //    _id = id;

        //}

        public bool CreateDocumentary(DocumentaryCreate model)
        {
            var entity =
                new Documentary()
                {
                    Id = _id,
                    Title = model.Title,
                    Description = model.Description,
                    Genre = model.Genre,
                    MaturityRating = model.MaturityRating,
                    RunTime = model.RunTime,

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Documentaries.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }


    }
}