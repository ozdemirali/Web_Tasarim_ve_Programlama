using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentFollow.ViewModel
{
    public class CreateDataViewModel
    {
        public CreateStudentViewModel CreateStudentViewModel { get; set; }
        public List<ClassroomViewModel> ClassroomViewModel { get; set; }
    }
}