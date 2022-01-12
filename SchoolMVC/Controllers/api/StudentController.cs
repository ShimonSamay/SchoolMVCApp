using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolMVC.Models;

namespace SchoolMVC.Controllers.api
{
    public class StudentController : ApiController
    {
        List<Student> studentsList = new List<Student>();
        public IHttpActionResult Get()
        {
            try
            {
                createList(); 
                return Ok(studentsList);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                createList();
                return Ok(studentsList.Find(stu => stu.Id == id));
            } catch (Exception x)
            {
                return BadRequest(x.Message);
            }
        }

        public IHttpActionResult Post([FromBody] Student newStu)
        {
            try
            {
                createList();
                studentsList.Add(newStu);
                return Ok(studentsList);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }
        }

        
        public IHttpActionResult Put(int id, [FromBody] Student updaed)
        {
            try
            {
                createList();
                Student someStudent = studentsList.Find(stu => stu.Id == id);
                studentsList[studentsList.IndexOf(someStudent)] = updaed;
                return Ok(studentsList);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }
        }

        
        public IHttpActionResult Delete(int id)
        {
            try
            {
                createList();
                studentsList.Remove(studentsList.Find(stu => stu.Id == id));
                return Ok(studentsList);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }

        }

        private void createList()
        {

            studentsList.Add(new Student(1, "shimon", "samay", "a", 22));
            studentsList.Add(new Student(2, "ermis", "mangisto", "c", 24));
            studentsList.Add(new Student(3, "matan", "ysays", "b", 25));
            studentsList.Add(new Student(4, "lior", "yosef", "d", 26));
        }


    }
}
