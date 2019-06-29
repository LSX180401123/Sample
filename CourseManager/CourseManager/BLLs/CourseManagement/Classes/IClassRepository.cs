using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager.BLLs.CourseManagement.Classes
{
    interface IClassRepository
    {
        List<CourseDetail> GetClassCourse(int id);
    }
}
