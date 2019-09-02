using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkApplication.Models
{
	public interface IAttractionRepository
	{
		Attraction GetAttraction(int id);
		IEnumerable<Attraction> GetAttractionList();
		Attraction Add(Attraction attraction);
		Attraction Update(Attraction changedAttraction);
		Attraction Delete(int id);
		void Destroy();
	}
}
