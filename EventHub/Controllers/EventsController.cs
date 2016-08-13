using EventHub.Models;
using EventHub.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
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
        
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new EventFormViewModel
            {
                Topics = _context.Topics.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(EventFormViewModel viewModel)
        {
            //var speakerId = User.Identity.GetUserId();
            //var speaker = _context.Users.Single(u => u.Id == speakerId);
            //var topic = _context.Topics.Single(t => t.Id == viewModel.Topic);

            var singleEvent = new Event
            {
                SpeakerId = User.Identity.GetUserId(),
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                TopicId = viewModel.Topic,
                Venue = viewModel.Venue

            };

            _context.Events.Add(singleEvent);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}