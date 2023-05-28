using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepPractice.Models;

namespace StepPractice.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly Entities _entities;

        public RegistrationController(Entities entities)
        {
            _entities = entities;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Users uc)
        {
            _entities.users.Add(uc);
            _entities.SaveChanges();
            ViewBag.message = "The user " + uc.username + " is saved successfully";
            return View();
        }
    }
}