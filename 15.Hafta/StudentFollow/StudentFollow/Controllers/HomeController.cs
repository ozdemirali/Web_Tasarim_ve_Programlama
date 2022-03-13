using StudentFollow.Context;
using StudentFollow.Models;
using StudentFollow.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentFollow.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var db=new StudentDbContext())
            {
                //var data = db.Students.ToList();
                var data = (from s in db.Students
                            join cl in db.Classrooms
                            on s.ClassroomId equals cl.Id
                            select new StudentViewModel()
                            {
                               Id= s.Id,
                               Name= s.Name,
                               Surname= s.Surname,
                               Gender=s.Gender==false?"Kadın":"Erkek",
                               ImagePath= s.ImagePath,
                               ClassName= cl.Name
                            }).ToList();

                return View(data); 
            }

           
        }

        [HttpGet]
        public ActionResult Create()
        {

            using (var db= new StudentDbContext())
            {
                //Test data = new Test();
                CreateDataViewModel data = new CreateDataViewModel();
                 data.ClassroomViewModel= db.Classrooms.Select(cl => new ClassroomViewModel()
                {
                    Id = cl.Id,
                    Name = cl.Name
                }).ToList();

                return View(data);
            }
           
        }

        [HttpPost]
        public ActionResult Create(CreateDataViewModel data,HttpPostedFileBase file)
        {

                string fileName = data.CreateStudentViewModel.Id+Path.GetExtension(file.FileName);
                string path = Path.Combine(Server.MapPath("~/Image"),fileName);
                file.SaveAs(path);

            using (var db=new StudentDbContext())
            {

                Student student = new Student
                {
                    Id = data.CreateStudentViewModel.Id,
                    Name = data.CreateStudentViewModel.Name,
                    Surname = data.CreateStudentViewModel.Surname,
                    Gender = data.CreateStudentViewModel.Gender,
                    ClassroomId = data.CreateStudentViewModel.ClassroomId,
                    ImagePath = fileName
                };
                db.Students.Add(student);
                db.SaveChanges();

            }
                return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            using (var db=new StudentDbContext())
            {
                //var student = db.Students.Find(id);
                var student = db.Students.Where(s => s.Id == id).FirstOrDefault();

                EditDataViewModel data = new EditDataViewModel();

                data.EditStudentViewModel = db.Students.Where(s => s.Id == id).Select(s => new EditStudentViewModel() {
                    Id = s.Id,
                    Name = s.Name,
                    Surname = s.Surname,
                    ImagePath = s.ImagePath,
                    Gender = s.Gender,
                    ClassroomId=s.ClassroomId,
                }).FirstOrDefault();

                data.ClassroomViewModel = db.Classrooms.Select(cl => new ClassroomViewModel()
                {
                    Id=cl.Id,
                    Name=cl.Name
                }).ToList();

                return View(data);
            }

           
        }

       [HttpPost]
        public ActionResult Edit(EditDataViewModel data, HttpPostedFileBase file)
        {
           

            using (var db=new StudentDbContext())
            {
                var student = db.Students.Find(data.EditStudentViewModel.Id);

                student.Name = data.EditStudentViewModel.Name;
                student.Surname = data.EditStudentViewModel.Surname;
                student.Gender = data.EditStudentViewModel.Gender;
                student.ClassroomId = data.EditStudentViewModel.ClassroomId;
                if (file != null && file.ContentLength > 0)
                {
                    string fileName = data.EditStudentViewModel.Id + Path.GetExtension(file.FileName);
                    string path = Path.Combine(Server.MapPath("~/Image"), fileName);
                    file.SaveAs(path);
                    student.ImagePath = fileName;

                }
                db.SaveChanges();

            }       

                return RedirectToAction("Index");
        }


      
        public ActionResult Delete(string id)
        {
            using (var db=new StudentDbContext())
            {
                var data = db.Students.Find(id);
                db.Students.Remove(data);
                db.SaveChanges();

                var fullPath = Server.MapPath("~/Image/" + data.ImagePath);

                if (System.IO.File.Exists(fullPath))
                {
                    System.IO.File.Delete(fullPath);
                }

                return RedirectToAction("Index");
            }

        }
    }
}