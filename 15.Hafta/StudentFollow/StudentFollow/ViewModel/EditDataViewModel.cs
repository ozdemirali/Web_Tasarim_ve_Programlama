using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentFollow.ViewModel
{
    public class EditDataViewModel
    {

        public EditStudentViewModel EditStudentViewModel { get; set; }
        public List<ClassroomViewModel> ClassroomViewModel { get; set; }
    }
}