using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibraryAPI.Models
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Description  { get; set; }

        public Guid AuthorId { get; set; }
    }
}
 