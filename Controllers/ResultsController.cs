using FirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCProject.Controllers
{
    public class ResultsController : Controller
    {
        public IActionResult Index()
        {
            //Creating students
            StudentResult studentResult = new StudentResult() { StudentID  = 22931, StudentName = "Marcos" };
            StudentResult studentResult2 = new StudentResult() { StudentID = 22932, StudentName = "Madelin" };
            StudentResult studentResult3 = new StudentResult() { StudentID = 22933, StudentName = "Mario" };
            StudentResult studentResult4 = new StudentResult() { StudentID = 22934, StudentName = "Graciele" };

            //Students Lists
            List<StudentResult> results = new List<StudentResult>();
            results.Add(studentResult);
            results.Add(studentResult2);
            results.Add(studentResult3);
            results.Add(studentResult4);

            return View(results);
        }
    }
}
