using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models.CRUD_Interfaces
{
	public interface IRouteRepository
	{
		Route RecalculateBest(Route route);
		Route RecalculateFastest(int id);
		Route Add(Route route);
		Route Update(Route changedRoute);
		Route GetRoute(int id);
		Route GetUserRoute(string username);
		Route DeleteRoute(int id);
	}
}
