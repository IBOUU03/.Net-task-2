using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Task_2.DataAccess;
using Task_2.Models;
using Task_2.ViewModels;

namespace Task_2.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            List<Student> students = Data.Students;
            List<Group> groups = Data.Groups;

            ProductViewModel productViewModel = new ProductViewModel
            {
                Students = students,
                Groups = groups
            };

            return View(productViewModel); 
        }
        public ViewResult Detail(int id) 
        {
            List<Student> students = Data.Students;

            var student = students.Find(x => x.Id == id);

            if (student == null)
            {
                return View("Error");
            }

            return View(student); 
        }  
    }
}
