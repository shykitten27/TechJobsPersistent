using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;

        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers
                .ToList();

            return View(employers);
        }

        public IActionResult Add()
        {
            List<Employer> employers = context.Employers.ToList();
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();

            return View(addEmployerViewModel);
        }

        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel) //class obj
        {
            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer //create an instance
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location
                };

                context.Employers.Add(newEmployer); //pass & save the instance
                context.SaveChanges();

                return Redirect("/Employer");
            }

            return View(addEmployerViewModel); 
        }

        public IActionResult About(int id)
        {
            Employer theEmployer = context.Employers.Find(id);

            return View(theEmployer); //pass the obj
        }
    }
}
