using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentFollow.Models
{
    public class Classroom
    {
        public byte Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}