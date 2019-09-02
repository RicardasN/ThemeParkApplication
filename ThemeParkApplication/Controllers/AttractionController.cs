using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThemeParkApplication.Data;
using ThemeParkApplication.Models;
using ThemeParkApplication.Models.CRUD_Interfaces;

namespace ThemeParkApplication.Controllers
{
	public class AttractionController : Controller
	{
		private IAttractionRepository _attractionRepository;
		private IMessageRepository _messageRepository;
		//needed to get all users from DB, so you could send messages
		private IUserRepository _userRepository;
		private IEnumerable<ApplicationUser> users;


		public AttractionController(IAttractionRepository attractionRepository, IMessageRepository messageRepository, IUserRepository userRepository)
		{
			_attractionRepository = attractionRepository;
			_messageRepository = messageRepository;
			_userRepository = userRepository;
			users = _userRepository.GetAllUsers();
		}

		[Route("Attraction")]
		[Route("Attraction/Index")]
		public ViewResult Index()
		{
			var model = _attractionRepository.GetAttractionList();
			return View(model);
		}

		[Route("Attraction/Details/{id?}")]
		public ViewResult Details(int? id)
		{
			var model = _attractionRepository.GetAttraction(id ?? 1);

			return View(model);
		}
		[HttpGet]
		public IActionResult Create()
		{
			if (User.IsInRole("Admin"))
			{
				return View();
			}
			else
			{
				return RedirectToAction("index");
			}
		}

		[HttpPost]
		public IActionResult Create(Attraction attraction)
		{
			if (ModelState.IsValid)
			{
				Attraction newAttraction = _attractionRepository.Add(attraction);
				return RedirectToAction("details", new { id = newAttraction.AttractionID });
			}
			return View();
		}
		public IActionResult Delete(int id)
		{
			if (id > 0)
			{
				Attraction newAttraction = _attractionRepository.Delete(id);
			}
			return RedirectToAction("index");
		}
		[HttpGet]
		public IActionResult Edit(int id)
		{
			if (User.IsInRole("Admin"))
			{
				Attraction attraction = _attractionRepository.GetAttraction(id);
				return View(attraction);
			}
			else
			{
				return RedirectToAction("index");
			}
		}

		[HttpPost]
		public IActionResult Edit(Attraction attraction)
		{
			if (ModelState.IsValid)
			{
				Attraction newAttraction = _attractionRepository.GetAttraction(attraction.AttractionID);
				newAttraction.Name = attraction.Name;
				newAttraction.Location = attraction.Location;
				newAttraction.Rating = attraction.Rating;
				newAttraction.ImageSrc = attraction.ImageSrc;
				newAttraction.Description = attraction.Description;
				_attractionRepository.Update(newAttraction);
				return RedirectToAction("details", new { id = newAttraction.AttractionID });
			}
			return View();
		}

		public IActionResult Close(int id)
		{
			if (User.IsInRole("Admin") || User.IsInRole("Employee"))
			{
				Attraction attraction = _attractionRepository.GetAttraction(id);
				Attraction newAttraction = _attractionRepository.GetAttraction(attraction.AttractionID);
				newAttraction.IsOpen = false;
				_attractionRepository.Update(newAttraction);

				//send message to all users about it
				String text = "Atsiprasome, taciau atrakcionas " + attraction.Name + " uzdarytas, jei jus planavote ji aplankyti tam nebera galimybes";
				this.SendMessageToAllUsers(text);

				if (newAttraction.IsOpen)
				{
					throw new Exception("Attraction should be closed but it is open");
				}

				return RedirectToAction("details", new { id = newAttraction.AttractionID });
			}
			else
			{
				return RedirectToAction("index");
			}
		}
		private void SendMessageToAllUsers(string Message)
		{
			var emails = new List<string>();

			foreach (var user in users)
			{
				emails.Add(user.Email);
			}

			foreach (var email in emails)
			{
				Message messageToSend = new Message { SentTime = DateTime.Now, Username = email, Text = Message };
				Message newMessage = _messageRepository.Add(messageToSend);
			}
		}

		public IActionResult Open(int id)
		{
			if (User.IsInRole("Admin") || User.IsInRole("Employee"))
			{
				Attraction attraction = _attractionRepository.GetAttraction(id);
				Attraction newAttraction = _attractionRepository.GetAttraction(attraction.AttractionID);
				newAttraction.IsOpen = true;
				_attractionRepository.Update(newAttraction);
				//send message to all users about it
				String text = "Atrakcionas " + attraction.Name + " ir vel atidarytas lankytojams, kvieciame apsilankyti";
				this.SendMessageToAllUsers(text);
				return RedirectToAction("details", new { id = newAttraction.AttractionID });
			}
			else
			{
				return RedirectToAction("index");
			}
		}
	}
}