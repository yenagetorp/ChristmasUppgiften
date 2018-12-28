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
                    Value = p.Id.ToString(),
                    Text = p.Name
                }).ToList();


                //viewModel.Senders = db.Present.ToList().Select(ps => new SelectListItem
                //{
                //    Value = ps.Rhyme,
                //    Text = ps.Sender
                //}).ToList();

                viewModel.Senders = new SelectListItem[]
                {
                    new SelectListItem{ Value = "1", Text = "Marianna" },
                    new SelectListItem{ Value = "2", Text = "Samuel" },
                    new SelectListItem{ Value = "3", Text = "Joel" },
                    new SelectListItem{ Value = "4", Text = "Mamma" },
                    new SelectListItem{ Value = "5", Text = "Pappa" },
                    new SelectListItem{ Value = "6", Text = "Elias" },
                    new SelectListItem{ Value = "7", Text = "Lineea" },
                    new SelectListItem{ Value = "8", Text = "Anders" },
                    new SelectListItem{ Value = "9", Text = "Lilla bro" }
                };



                //People = new List<SelectListItem>
                //{
                //    new SelectListItem { Value = "1", Text = "Samuel" },
                //    new SelectListItem { Value = "2", Text = "Elias", Selected = true },
                //    new SelectListItem { Value = "3", Text = "Lineea" }
                //  };

                return View(viewModel);
            }
        }


        [HttpPost]
        public IActionResult CreatePresents(ChristmasPresentsCreateVM present)
        {
          
            service.CreatePresents(present);
            return RedirectToAction(nameof(Index));
        }


    }
}