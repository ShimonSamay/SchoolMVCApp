using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolMVC.Models
{
    public class Student
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Grade;
        public int Age;

        public Student(int _id , string _firstname , string _lastname , string _grade , int _age ) {
        this.Id = _id;
        this.FirstName = _firstname;
        this.LastName = _lastname;
        this.Grade = _grade;
        this.Age = _age;    
        }

        public Student() { }

     
        
    }
}