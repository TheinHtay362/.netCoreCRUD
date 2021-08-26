using CRUDDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentModel student = new StudentModel();
            student.Id = 1;
            student.Name = "Mg Mg";
            student.NRC_No = "NRC No";
            student.Gender = "Male";
            student.Address = "Yangon";
            student.PhoneNo = "09453435344";

            List<StudentModel> model = new List<StudentModel>();
            model.Add(student);
            return View(model);
        }

        public IActionResult Create()
        {
            StudentModel model = new StudentModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(StudentModel model)
        {
            return View();
        }

        public IActionResult Update()
        {
            StudentModel model = new StudentModel();
            model.Id = 1;
            model.Name = "Mg Mg";
            model.NRC_No = "NRC No";
            model.Gender = "Male";
            model.Address = "Yangon";
            model.PhoneNo = "09453435344";
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(StudentModel studentModel)
        {
            //StudentModel model = new StudentModel();
            return View();
        }
    }
}
