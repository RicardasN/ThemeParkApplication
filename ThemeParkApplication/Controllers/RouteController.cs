using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThemeParkApplication.Models;
using ThemeParkApplication.Models.CRUD_Interfaces;

namespace ThemeParkApplication.Controllers
{
	public class RouteController : Controller
	{
		private IRouteRepository _routeRepository;
		private IAttractionRepository _attractionRepository;
		private IRouteAttraction _routeAttractionRepository;

		public RouteController(IRouteRepository routeRepository, IAttractionRepository attractionRepository, IRouteAttraction routeAttraction)
		{
			_routeRepository = routeRepository;
			_attractionRepository = attractionRepository;
			_routeAttractionRepository = routeAttraction;
		}
		[Route("Route")]
		[Route("Route/Index")]
		[HttpGet]
		public IActionResult Index()
		{
			List<Attraction> AllAtractions = _attractionRepository.GetAttractionList().ToList();
			var model = _routeRepository.GetUserRoute(User.Identity.Name);
			List<Attraction> AllAtractions1 = _routeAttractionRepository.GetAttractions(model);

			foreach (Attraction attraction in AllAtractions1)
			{
				AllAtractions.Remove(attraction);
			}

			ViewBag.Attractions = AllAtractions;
			ViewBag.UserAttractions = AllAtractions1;
			//ViewBag.UserAttractions = AllAtractions1.OrderByDescending(x => x.).ToList();

			return View(model);
		}
		[HttpPost]
		public IActionResult Index(Route stuff)
		{
			Route newRoute = _routeRepository.GetUserRoute(User.Identity.Name);
			RouteAttraction route = new RouteAttraction()
			{
				RouteId = newRoute.RouteID,
				Route = newRoute,
				AtractionId = stuff.TempAtractionID,
				Attraction = _attractionRepository.GetAttraction(stuff.TempAtractionID),
			};

			List<RouteAttraction> routeAttractions = new List<RouteAttraction>();
			if (newRoute.RouteAttractions != null)
				routeAttractions = newRoute.RouteAttractions;

			route.Index = routeAttractions.Count;
			routeAttractions.Add(route);
			newRoute.RouteAttractions = routeAttractions;
			_routeRepository.Update(newRoute);
			return RedirectToAction("index");
		}
		public IActionResult Remove(int id)
		{
			Route newRoute = _routeRepository.GetUserRoute(User.Identity.Name);
			List<Attraction> AllAtractions1 = _routeAttractionRepository.GetAttractions(newRoute);

			RouteAttraction route = new RouteAttraction()
			{
				RouteId = newRoute.RouteID,
				Route = newRoute,
				AtractionId = id,
				Attraction = _attractionRepository.GetAttraction(id),
				Index = id - 1
			};

			List<RouteAttraction> routeAttractions = newRoute.RouteAttractions;
			routeAttractions.Remove(route);
			//routeAttractions.RemoveAll(x => x.Attraction == _attractionRepository.GetAttraction(id));

			newRoute.RouteAttractions = routeAttractions;
			_routeRepository.Update(newRoute);
			return RedirectToAction("index");
		}
		public IActionResult Recalculate(int id)
		{
			List<Attraction> AllAtractions = _attractionRepository.GetAttractionList().ToList();

			Route newRoute = _routeRepository.GetUserRoute(User.Identity.Name);
			List<Attraction> AllAtractions1 = _routeAttractionRepository.GetAttractions(newRoute);
			
			_routeRepository.RecalculateBest(newRoute);

			return RedirectToAction("index");
		}
	}
}