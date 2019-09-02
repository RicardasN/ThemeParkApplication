using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemeParkApplication.Data;
using ThemeParkApplication.Models.CRUD_Interfaces;

namespace ThemeParkApplication.Models.DB_Classes
{
	public class MySqlRouteRepository : IRouteRepository
	{
		private readonly ApplicationDbContext context;
		public MySqlRouteRepository(ApplicationDbContext context)
		{
			this.context = context;
		}
		public Route Add(Route route)
		{
			context.Routes.Add(route);
			context.SaveChanges();
			return route;
		}

		public Route DeleteRoute(int id)
		{
			Route route = context.Routes.Find(id);
			if (route != null)
			{
				context.Routes.Remove(route);
				context.SaveChanges();
			}
			return route;
		}

		public Route GetRoute(int id)
		{
			var route = context.Routes.Find(id);
			route.RouteAttractions = route.RouteAttractions.OrderBy(x => x.Index).ToList();
			return context.Routes.Find(id);
		}
		public Route GetUserRoute(string username)
		{
			IEnumerable<Route> routes = context.Routes.Where(route => route.ApplicationUser == username);
			if (routes == null || routes.Count() == 0)
			{
				Route route = new Route()
				{
					ApplicationUser = username,
					RouteAttractions = new List<RouteAttraction>(),
					RouteCafeterias = new List<Cafeteria>()
				};
				this.Add(route);
				return route;
			}
			return routes.ToList()[0];
		}

		public Route RecalculateBest(Route routeToRecalculate)
		{
			var routeAttractions = routeToRecalculate.RouteAttractions.OrderByDescending(o => o.Attraction.Rating).ToList();
			var i = 0;

			foreach (var item in routeAttractions)
			{
				item.Index = i;
				i++;
			}

			routeToRecalculate.RouteAttractions = routeAttractions;

			//Route route = context.Routes.Find(routeToRecalculate.RouteID);
			//context.Routes.Remove(route);
			//context.SaveChanges();

			//context.Routes.Add(routeToRecalculate);
			//context.SaveChanges();

			context.Update(routeToRecalculate);
			context.SaveChanges();

			return routeToRecalculate;

		}

		public Route RecalculateFastest(int id)
		{

			return context.Routes.Find(id);
		}

		public Route Update(Route changedRoute)
		{
			var route = context.Routes.Attach(changedRoute);
			route.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			context.SaveChanges();
			return changedRoute;
		}
	}
}
