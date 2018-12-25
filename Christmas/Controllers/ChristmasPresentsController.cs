using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Christmas.Models;
using Christmas.Models.Entities;
using Christmas.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Christmas.Controllers
{
    public class ChristmasPresentsController : Controller
    {
        ChristmasPresentsService service;
        public ChristmasPresentsController(ChristmasPresentsService service)
        {
            this.service = service;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(service.GetAllPeople());
        }


        [Route("")]
        [HttpPost]
        public IActionResult Index(ChristmasPeopleCreateVM person)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(person);
            //}
            service.AddAPerson(person);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
       // [Route("/ChristmasPresents/CreatePresents")]
        public IActionResult CreatePresents()
        {
            var viewModel = new ChristmasPresentsCreateVM();

            using (var db = new GiftsContext())
            {
                //viewModel.Rhyme= db.Present.
                viewModel.People = db.Person.ToList().Select(p => new SelectListItem
                {
                    Value=p.Id.ToString(),
                    Text=p.Name
                }).ToList();
            }

           // {
                //People = new List<SelectListItem>
                //{
                //    new SelectListItem { Value = "1", Text = "Samuel" },
                //    new SelectListItem { Value = "2", Text = "Elias", Selected = true },
                //    new SelectListItem { Value = "3", Text = "Lineea" }
          //  };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CreatePresents(ChristmasPresentsCreateVM present)
        {
            service.CreatePresents(present);
            return RedirectToAction(nameof(Index));
        }

    }
}