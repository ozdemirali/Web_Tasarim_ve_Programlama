using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentFollow.ViewModel
{
    public class EditStudentViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImagePath { get; set; }
        public bool Gender { get; set; }
        public byte ClassroomId { get; set; }
    }
}