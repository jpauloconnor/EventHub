using EventHub.Models;
using EventHub.ViewModels;
using Microsoft.AspNet.Identity;
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Topics = _context.Topics.ToList();
                return View("Create", viewModel);
            };

            var singleEvent = new Event
            {
                SpeakerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                TopicId = viewModel.Topic,
                Venue = viewModel.Venue

            };

            _context.Events.Add(singleEvent);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}