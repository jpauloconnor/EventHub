using EventHub.Models;
using EventHub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventHub.Controllers
{
    public class EventsController : Controller
    {
        private ApplicationDbContext _context;
        
        public EventsController()
        {
            _context = new ApplicationDbContext();
        }
        
        // GET: Events
        public ActionResult Create()
        {
            var viewModel = new EventFormViewModel
            {
                Topics = _context.Topics.ToList()
            };

            return View(viewModel);
        }
    }
}