using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThemeParkApplication.Models;
using ThemeParkApplication.Models.CRUD_Interfaces;

namespace ThemeParkApplication.Controllers
{
    public class MessageController : Controller
    {
		private IMessageRepository _messageRepository;

		public MessageController(IMessageRepository messageRepository)
		{
			_messageRepository = messageRepository;
		}

		[Route("Message")]
		[Route("Message/Index")]
		public ViewResult Index()
		{
			var model = _messageRepository.GetAllMessages(User.Identity.Name);
			return View(model);
		}
		[HttpGet]
		public IActionResult Create()
		{
			if (User.IsInRole("Admin") || User.IsInRole("Employee"))
			{
				return View();
			}
			else
			{
				return RedirectToAction("index");
			}
		}

		[HttpPost]
		public IActionResult Create(Message message)
		{
			List<String> usernames = new List<String>();
			foreach (var indentity in User.Identities.ToList())
			{
				usernames.Add(indentity.Name);
			}
			
			if (ModelState.IsValid)
			{
				message.Username = User.Identity.Name;
				message.SentTime = DateTime.Now;
				Message newMessage = _messageRepository.Add(message);
				return RedirectToAction("index");
			}
			return View();
		}
		public IActionResult Delete(int id)
		{
			if (id > 0)
			{
				Message newAttraction = _messageRepository.Delete(id);
			}
			return RedirectToAction("index");
		}
	}
}