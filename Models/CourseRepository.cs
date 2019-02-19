using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWeb.Models
{
    public class CourseRepository: Repository<Course>
    {
        public CourseRepository(DataContext context) : base(context) {
        }

    }
}
