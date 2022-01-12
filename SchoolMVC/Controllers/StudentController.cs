using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers
{
    public class StudentController : Controller
    {
        
        List<Student> studentsList = new List<Student>();   
        public ActionResult getStudentName()
        {
            createList();
            ViewBag.Name = studentsList[0].FirstName;
            return View();
        }

        public ActionResult getStudent(int id)
        {
            createList();
            ViewBag.stu = studentsList.Find(stu => stu.Id == id);
            return View();
        }

        public ActionResult getAllStudents ()
        {
            createList();
            ViewBag.list = studentsList;
            return View();
        }

        public void createList()
        {
            
            studentsList.Add(new Student(1, "shimon", "samay", "a", 22));
            studentsList.Add(new Student(2, "ermis", "mangisto", "c", 24));
            studentsList.Add(new Student(3, "matan", "ysays", "b", 25));
            studentsList.Add(new Student(4, "lior", "yosef", "d", 26));
        }

    }
}